using System.Collections;
using WynncraftSharp.API.Versioning;

namespace WynncraftSharp.API.Requests.Collections;

///<inheritdoc cref="IRequestCollection{T}"/>
public abstract class RequestCollectionBase<T> : RequestBase, IRequestCollection<T>
{
    // ReSharper disable once MemberCanBePrivate.Global
    public abstract T[] Collection { get; internal set; }
    
    public IEnumerator<T> GetEnumerator()
    {
        return Collection.ToList().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
    protected RequestCollectionBase(IWynncraftApiClient client, string endpoint, string dataObjectName) : base(client, endpoint)
    {
        DataName = dataObjectName;
    }
    
    protected RequestCollectionBase(IWynncraftApiClient client, VersionedEndpoint endpoint) : base(client, endpoint)
    {
    }
    
    protected RequestCollectionBase(IWynncraftApiClient client, VersionedEndpoint endpoint, string dataObjectName) : base(client, endpoint)
    {
        DataName = dataObjectName;
    }

    public string DataName { get; }
}