using Divoom.Models;
using System.Text.Json;

namespace Divoom;

public class Service
{
    private const string BaseUrl = "http://app.divoom-gz.com";

    internal class DeviceListResult
    {
        public IEnumerable<DeviceInfo> DeviceList { get; set; } = new List<DeviceInfo>();
    }

    public static async Task<IEnumerable<DeviceInfo>> FindDevices()
    {
        const string url = $"{BaseUrl}/Device/ReturnSameLANDevice";
        var response = await WebApi.Get(url);
        
        var result = JsonSerializer.Deserialize<DeviceListResult>(response);
        return result?.DeviceList ?? [];
    }

    internal class DialTypeResponse
    {
        public IEnumerable<string> DialTypeList { get; set; } = new List<string>();
    }

    public static async Task<IEnumerable<string>> GetDialTypes()
    {
        const string url = $"{BaseUrl}/Channel/GetDialType";
        var response = await WebApi.Get(url);
        
        var result = JsonSerializer.Deserialize<DialTypeResponse>(response);
        return result?.DialTypeList ?? [];
    }

    internal class DialResponse
    {
        public IEnumerable<Dial> DialList { get; set; } = new List<Dial>();
    }

    public static async Task<IEnumerable<Dial>> GetDialList(string dialType, int page = 1)
    {
        const string url = $"{BaseUrl}/Channel/GetDialList";

        var data = JsonSerializer.Serialize(new {DialType= dialType, Page = page });

        var response = await WebApi.Post(url, data);

        var result = JsonSerializer.Deserialize<DialResponse>(response);
        return result?.DialList ?? [];
    }

    internal class ClockListResponse
    {
        public IEnumerable<Clock> ClockList { get; set; } = new List<Clock>();
    }

    public static async Task<IEnumerable<Clock>> GetClockList(int page = 1)
    {
        const string url = $"{BaseUrl}/Channel/Get5LcdClockListForCommon";
        var data = JsonSerializer.Serialize(new { Page = page });
        var response = await WebApi.Post(url, data);
        var result = JsonSerializer.Deserialize<ClockListResponse>(response);
        return result?.ClockList ?? [];
    }

    public static async Task<ChannelInformation> GetChannelInformation(int deviceId)
    {
        const string url = $"{BaseUrl}/Channel/Get5LcdInfoV2";
        var data = JsonSerializer.Serialize(new {DeviceId = deviceId, DeviceType = "LCD" });
        var response = await WebApi.Post(url, data);

        
        return JsonSerializer.Deserialize<ChannelInformation>(response) ?? new ChannelInformation();
    }

    internal class ImageListResponse
    {
        public IEnumerable<ImageInfo> ImgList { get; set; } = new List<ImageInfo>();
    }

    public static async Task<IEnumerable<ImageInfo>> GetLikedImages(DeviceInfo device, int page = 1)  
    {
        const string url = $"{BaseUrl}/Device/GetImgLikeList";
        var data = JsonSerializer.Serialize(new { DeviceId = device.Id, DeviceMac = device.MacAddress });
        var response = await WebApi.Post(url, data);
        
        var result = JsonSerializer.Deserialize<ImageListResponse>(response);
        return result?.ImgList ?? [];
    }

    public static async Task<IEnumerable<ImageInfo>> GetImageUploadList(DeviceInfo device, int page = 1)
    {
        const string url = $"{BaseUrl}/Device/GetImgUploadList";
        var data = JsonSerializer.Serialize(new { DeviceId = device.Id, DeviceMac = device.MacAddress });
        var response = await WebApi.Post(url, data);
        
        var result = JsonSerializer.Deserialize<ImageListResponse>(response);
        return result?.ImgList ?? [];
    }

    internal class FontListResponse
    {
        public IEnumerable<Font> FontList { get; set; } = new List<Font>();
    }   

    public static async Task<IEnumerable<Font>> GetFonts()
    {
        const string url = $"{BaseUrl}/Device/GetTimeDialFontList";
        var response = await WebApi.Post(url, "");

        var result = JsonSerializer.Deserialize<FontListResponse>(response);
        return result?.FontList ?? [];
    }
}