using System.Text.Json.Serialization;

namespace Divoom.Models;

public class Lcd
{
    [JsonPropertyName("LcdClockId")]
    public int ClockId { get; set; }

    [JsonPropertyName("LcdSelectIndex")]
    public int SelectIndex { get; set; }

    public string ClockImagePixelId { get; set; } = "";
}

public class LcdIndependence
{
    [JsonPropertyName("LcdIndependence")]
    public int Id { get; set; } 

    [JsonPropertyName("IndependenceName")]
    public string Name { get; set; } = "";

    [JsonPropertyName("LcdIndependPos")]
    public int Position { get; set; }

    public IEnumerable<Lcd> LcdList { get; set; } = new List<Lcd>();
}