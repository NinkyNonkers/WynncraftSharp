using WynncraftSharp.Requests.Collections;
using WynncraftSharp.Requests.Objects;

namespace WynncraftSharp.Requests.Latest;

public abstract class LatestRequestCollectionBase<T> : RequestCollectionBase<T>, ILatestRequest where T : IRequestObject
{
    protected LatestRequestCollectionBase(string endpoint, string dataObjectName) : base(endpoint, dataObjectName)
    {
    }

    public string Kind { get; internal set; }
    public int Code { get; internal set; }
    public string Message { get; internal set; }
    public ulong Timestamp { get; internal set; }
    public string Version { get; internal set; }
}