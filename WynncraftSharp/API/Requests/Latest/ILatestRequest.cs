namespace WynncraftSharp.API.Requests.Latest;

/// <summary>
/// Request format for V2 and V3 versions
/// </summary>
public interface ILatestRequest : IRequest
{
    public string Kind { get; }
    public int Code { get; }
    public string Message { get; }
    public ulong Timestamp { get; }
    public string Version { get; }
}