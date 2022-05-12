using WynncraftSharp.Requests.Collections;

namespace WynncraftSharp.Requests.Legacy;

public abstract class LegacyRequestCollectionBase<T> : RequestCollectionBase<T>, ILegacyRequest
{
    protected LegacyRequestCollectionBase(IWynncraftApiClient client, string endpoint, string dataObjectName) : base(client, endpoint, dataObjectName)
    {
        
    }

    public LegacyRequestInformation Request { get; internal set; }
}