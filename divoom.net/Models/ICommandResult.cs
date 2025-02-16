using System.Text.Json.Serialization;

namespace Divoom.Models;

public interface ICommandResult
{
    [JsonPropertyName("error_code")]
    public int ErrorCode { get; set; }
}