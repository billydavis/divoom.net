namespace Divoom.Models;

public class ChannelInformation
{
    public int ChannelType { get; set; }

    public int LcdIndependence { get; set; }

    public int ClockId { get; set; }

    public int DeviceId { get; set; }

    public IEnumerable<LcdIndependence> LcdIndependenceList { get; set; } = new List<LcdIndependence>();
}