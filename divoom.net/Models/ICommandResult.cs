namespace Divoom.Models;

public interface ICommandResult
{
    // The JSON name ("error_code") must be set on each implementing class:
    // System.Text.Json ignores attributes declared on interface members.
    public int ErrorCode { get; set; }
}
