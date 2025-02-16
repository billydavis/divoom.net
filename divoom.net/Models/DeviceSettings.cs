namespace Divoom.Models;

public class DeviceSettings : ICommandResult
{
    public int ErrorCode { get; set; }

    public int Brightness { get; set; }

    public string DateFormat { get; set; } = "";

    public int Time24Flag { get; set; }

    public int TemperatureMode { get; set; }

    public int MirrorFlag { get; set; }

    public int LightSwitch { get; set; }
}