using System.Text;
using Divoom.Extensions;

namespace Divoom;

internal class WebApi
{
    // One shared client for the whole app. Creating a new HttpClient per request
    // leaves sockets in TIME_WAIT and can exhaust them when polling every few seconds.
    // PooledConnectionLifetime makes pooled connections pick up DNS changes.
    private static readonly HttpClient Client = new(new SocketsHttpHandler
    {
        PooledConnectionLifetime = TimeSpan.FromMinutes(5)
    });

    /// <param name="timeout">Per-request timeout; null uses HttpClient's default (100 s).</param>
    public static async Task<string> Get(string url, TimeSpan? timeout = null)
    {
        using var cts = CreateTimeout(timeout);

        try
        {
            using var response = await Client.GetAsync(url, cts.Token);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync(cts.Token);
        }
        catch (OperationCanceledException) when (cts.IsCancellationRequested)
        {
            return TimeoutError(url, timeout).ToJson();
        }
        catch (Exception ex)
        {
            return ex.ToJson();
        }
    }

    /// <param name="timeout">Per-request timeout; null uses HttpClient's default (100 s).</param>
    public static async Task<string> Post(string url, string json, TimeSpan? timeout = null)
    {
        using var content = (!string.IsNullOrEmpty(json))
            ? new StringContent(json, Encoding.UTF8, "application/json")
            : null;

        using var cts = CreateTimeout(timeout);

        try
        {
            using var response = await Client.PostAsync(url, content, cts.Token);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync(cts.Token);
        }
        catch (OperationCanceledException) when (cts.IsCancellationRequested)
        {
            return TimeoutError(url, timeout).ToJson();
        }
        catch (Exception ex)
        {
            return ex.ToJson();
        }
    }

    private static CancellationTokenSource CreateTimeout(TimeSpan? timeout) =>
        timeout is { } t ? new CancellationTokenSource(t) : new CancellationTokenSource();

    private static TimeoutException TimeoutError(string url, TimeSpan? timeout) =>
        new($"No response from {url} within {timeout?.TotalSeconds:0.#} seconds.");
}
