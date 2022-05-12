using WynncraftSharp.Requests.Collections;

namespace WynncraftSharp.Requests.Latest;

public abstract class LatestRequestCollectionBase<T> : RequestCollectionBase<T>, ILatestRequest
{
    protected LatestRequestCollectionBase(IWynncraftApiClient client, string endpoint, string dataObjectName) : base(client, endpoint, dataObjectName)
    {
    }

    public string Kind { get; internal set; }
    public int Code { get; internal set; }
    public string Message { get; internal set; }
    public ulong Timestamp { get; internal set; }
    public string Version { get; internal set; }
}