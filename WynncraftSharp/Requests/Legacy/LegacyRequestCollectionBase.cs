using WynncraftSharp.Requests.Collections;
using WynncraftSharp.Requests.Objects;

namespace WynncraftSharp.Requests.Legacy;

public abstract class LegacyRequestCollectionBase<T> : RequestCollectionBase<T>, ILegacyRequest where T : IRequestObject
{
    protected LegacyRequestCollectionBase(string endpoint, string dataObjectName) : base(endpoint, dataObjectName)
    {
        
    }

    public LegacyRequestInformation Request { get; internal set; }
}