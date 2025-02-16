using System.Text.Json.Serialization;

namespace pcMonitor.Commands;

public class PcMonitorScreenData
{
    public int? LcdId { get; set; }

    [JsonPropertyName("DispData")] 
    public IEnumerable<string> DisplayData { get; set; } = new List<string>();
}

public class PcMonitorCommand
{
    public string Command { get; set; } = "Device/UpdatePCParaInfo";
    public IEnumerable<PcMonitorScreenData> ScreenList { get; set; } = new List<PcMonitorScreenData>();
}