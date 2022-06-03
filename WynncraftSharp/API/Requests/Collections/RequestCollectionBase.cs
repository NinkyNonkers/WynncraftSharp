using System.Collections;

namespace WynncraftSharp.API.Requests.Collections;

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
    
    protected RequestCollectionBase(IWynncraftApiClient client, string endpoint, string dataObjectName) : base(client)
    {
        Endpoint = endpoint;
        DataName = dataObjectName;
    }

    public override string Endpoint { get; }
    public string DataName { get; }
}