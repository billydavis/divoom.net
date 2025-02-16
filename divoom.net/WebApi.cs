using System.Text;
using Divoom.Extensions;

namespace Divoom;

internal class WebApi
{
    public static async Task<string> Get(string url)
    {
        using var client = new HttpClient();

        try
        {
            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        catch (Exception ex)
        {
            return ex.ToJson();
        }
    }

    public static async Task<string> Post(string url, string json)
    {
        using var client = new HttpClient();
        
        var content = (!string.IsNullOrEmpty(json)) 
            ? new StringContent(json, Encoding.UTF8, "application/json") 
            : null;

        try
        {
            var response = await client.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        catch (Exception ex)
        {
            return ex.ToJson();
        }
        
    }   
}