using WynncraftSharp.API.Requests.Objects;
using WynncraftSharp.API.Versioning;

namespace WynncraftSharp.API.Requests.Latest;

public abstract class LatestRequestObjectBase : RequestObjectBase, ILatestRequest
{
    protected LatestRequestObjectBase(IWynncraftApiClient client, string endpoint, string dataObjectName) : base(client, endpoint, dataObjectName)
    {
        ExpectedApiVersion = ApiVersion.V2;
    }

    protected LatestRequestObjectBase(IWynncraftApiClient client, string endpoint) : base(client, endpoint)
    {
        ExpectedApiVersion = ApiVersion.V2;
    }

    public string Kind { get; internal set; }
    public int Code { get; internal set; }
    public string Message { get; internal set; }
    public ulong Timestamp { get; internal set; }
    public string Version { get; internal set; }
}