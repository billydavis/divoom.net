using System.Text.Json.Serialization;

namespace Divoom.Models;

public class Font
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    [JsonPropertyName("width")] 
    public string Width { get; set; } = "";

    [JsonPropertyName("high")] 
    public string Height { get; set; } = "";

    [JsonPropertyName("type")]
    public int Type { get; set; }

    [JsonPropertyName("charset")]
    public string Setting { get; set; } = "";

    [JsonPropertyName("fontUrl")]
    public string Url { get; set; } = "";   

}