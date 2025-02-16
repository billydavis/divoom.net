using System.Text.Json.Serialization;

namespace Divoom.Models;

public class Clock
{
    [JsonPropertyName("ClockId")]
    public int Id { get; set; }

    [JsonPropertyName("ClockName")]
    public string Name { get; set; } = "";

    [JsonPropertyName("ClockExPlain")]
    public string Description { get; set; } = "";
}