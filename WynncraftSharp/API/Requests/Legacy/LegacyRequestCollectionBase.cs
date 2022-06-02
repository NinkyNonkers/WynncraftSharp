using WynncraftSharp.API.Requests.Collections;
using WynncraftSharp.API.Versioning;

namespace WynncraftSharp.API.Requests.Legacy;

public abstract class LegacyRequestCollectionBase<T> : RequestCollectionBase<T>, ILegacyRequest
{
    protected LegacyRequestCollectionBase(IWynncraftApiClient client, string endpoint, string dataObjectName) : base(client, endpoint, dataObjectName)
    {
        ExpectedApiVersion = ApiVersion.Legacy;
    }
    
    protected LegacyRequestCollectionBase(IWynncraftApiClient client, VersionedEndpoint endpoint, string dataObjectName) : base(client, endpoint, dataObjectName)
    {
        ExpectedApiVersion = ApiVersion.Legacy;
    }

    public LegacyRequestInformation Request { get; internal set; }
}