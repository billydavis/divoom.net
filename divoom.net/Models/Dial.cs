using System.Text.Json.Serialization;

namespace Divoom.Models;

public class Dial
{
    [JsonPropertyName("ClockId")]
    public int Id { get; set; }
    public string Name { get; set; } = "";
}