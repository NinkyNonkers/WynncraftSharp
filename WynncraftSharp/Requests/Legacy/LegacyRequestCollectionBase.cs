using WynncraftSharp.Requests.Collections;

namespace WynncraftSharp.Requests.Legacy;

public abstract class LegacyRequestCollectionBase<T> : RequestCollectionBase<T>, ILegacyRequest
{
    protected LegacyRequestCollectionBase(string endpoint, string dataObjectName) : base(endpoint, dataObjectName)
    {
        
    }

    public LegacyRequestInformation Request { get; internal set; }
}