using System.Text.Json.Serialization;

namespace Divoom.Models;

public class ImageInfo
{
    [JsonPropertyName("FileId")]
    public string Id { get; set; } = "";

    [JsonPropertyName("FileName")]
    public string Name { get; set; } = "";
}