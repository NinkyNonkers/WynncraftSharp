using WynncraftSharp.API.Requests.Objects;
using WynncraftSharp.API.Versioning;

namespace WynncraftSharp.API.Requests.Legacy;

public abstract class LegacyRequestObjectBase : RequestObjectBase, ILegacyRequest
{
    public LegacyRequestInformation Request { get; internal set; }

    protected LegacyRequestObjectBase(IWynncraftApiClient client, string endpoint, string dataObjectName) : base(client, endpoint, dataObjectName)
    {
        ExpectedApiVersion = ApiVersion.Legacy;
    }

    protected LegacyRequestObjectBase(IWynncraftApiClient client, string endpoint) : base(client, endpoint)
    {
        ExpectedApiVersion = ApiVersion.Legacy;
    }
    
    protected LegacyRequestObjectBase(IWynncraftApiClient client, VersionedEndpoint endpoint, string dataObjectName) : base(client, endpoint, dataObjectName)
    {
        ExpectedApiVersion = ApiVersion.Legacy;
    }

    protected LegacyRequestObjectBase(IWynncraftApiClient client, VersionedEndpoint endpoint) : base(client, endpoint)
    {
        ExpectedApiVersion = ApiVersion.Legacy;
    }
}