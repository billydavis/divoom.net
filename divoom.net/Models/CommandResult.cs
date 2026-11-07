using System.Text.Json.Serialization;

namespace Divoom.Models;

public class CommandResult : ICommandResult
{
    [JsonPropertyName("error_code")]
    public int ErrorCode { get; set; }
}
