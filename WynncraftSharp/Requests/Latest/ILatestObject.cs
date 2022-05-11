namespace WynncraftSharp.Requests.Latest;

public interface ILatestObject
{
    public string Kind { get; }
    public int Code { get; }
    public string Message { get; }
    public ulong Timestamp { get; }
    public string Version { get; }
}