using Divoom.Models;
using System.Text.Json;

namespace Divoom;

public class Device()
{
    private readonly DeviceInfo _deviceInfo;
    private readonly string _url;

    public Device(string ipAddress) : this()
    {
        _deviceInfo = new DeviceInfo { IpAddress = ipAddress };
        _url = $"http://{ipAddress}/post";
    }

    public Device(DeviceInfo deviceInfo) : this()
    {
        _deviceInfo = deviceInfo;
        _url = $"http://{deviceInfo.IpAddress}/post";
    }

    public bool Reboot()
    {
        var data = JsonSerializer.Serialize(new { Command = "Device/SysReboot" });

        return CheckCommandResult(SendCommand<CommandResult>(data).Result);
    }

    public bool SetBrightness(int level)
    {
        if(level is < 0 or > 100)
            throw new ArgumentOutOfRangeException(nameof(level), "Brightness level must be between 0 and 100");
        
        var data = JsonSerializer.Serialize(new { Command = "Channel/SetBrightness", Brightness = level });

        return CheckCommandResult(SendCommand<CommandResult>(data).Result);
    }

    public DeviceSettings? GetAllSettings()
    {
        var data = JsonSerializer.Serialize(new { Command = "Channel/GetAllConf" });
        return SendCommand<DeviceSettings>(data).Result;
    }

    private bool CheckCommandResult(ICommandResult? result)
    {
        if (result is null)
            throw new Exception("No response from device");

        return result.ErrorCode == 0;
    }

    public async Task<bool> SetSubDial(int clockId, int lcd, int lcdIndependence = 0)
    {
        var data = JsonSerializer.Serialize(new
        {
            Command = "Channel/SetClockSelectId",
            ClockId = clockId,
            LcdIndex = lcd,
            LcdIndependence = lcdIndependence
        });

        var result = await SendCommand<CommandResult>(data);
        return CheckCommandResult(result);
    }

    public async Task<T?> SendCommand<T>(string data)
    {
        var response = await WebApi.Post(_url, data);

        var result = JsonSerializer.Deserialize<T>(response);

        return result;

    }
}