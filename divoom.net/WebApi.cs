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

    public static async Task<string> Get(string url)
    {
        try
        {
            using var response = await Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        catch (Exception ex)
        {
            return ex.ToJson();
        }
    }

    public static async Task<string> Post(string url, string json)
    {
        using var content = (!string.IsNullOrEmpty(json))
            ? new StringContent(json, Encoding.UTF8, "application/json")
            : null;

        try
        {
            using var response = await Client.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        catch (Exception ex)
        {
            return ex.ToJson();
        }
    }
}
