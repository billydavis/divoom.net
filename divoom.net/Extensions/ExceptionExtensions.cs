using System.Text.Json;

namespace Divoom.Extensions;

public static class ExceptionExtensions
{
    /// <summary>
    /// Error code reported when a request fails before the device answers
    /// (timeout, unreachable host, HTTP error). Devices report 0 for success.
    /// </summary>
    public const int RequestFailedErrorCode = -1;

    // Serialized (not string-formatted) so quotes in the message can't break the JSON.
    public static string ToJson(this Exception ex) =>
        JsonSerializer.Serialize(new Dictionary<string, object>
        {
            ["error_code"] = RequestFailedErrorCode,
            ["error"] = ex.Message
        });
}
