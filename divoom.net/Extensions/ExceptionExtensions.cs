namespace Divoom.Extensions;

public static class ExceptionExtensions
{
    public static string ToJson(this Exception ex) => $"{{\"error\": \"{ex.Message}\"}}";
}