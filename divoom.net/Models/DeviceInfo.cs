using System.Text.Json.Serialization;

namespace Divoom.Models;

public class DeviceInfo()
{
    [JsonPropertyName("DeviceId")]
    public int? Id { get; set; }

    public int? Hardware { get; set; }

    [JsonPropertyName("DeviceName")]
    public string Name { get; set; } = "";

    [JsonPropertyName("DevicePrivateIP")]
    public string IpAddress { get; set; } = "";

    [JsonPropertyName("DeviceMac")]
    public string MacAddress { get; set; } = "";
}
