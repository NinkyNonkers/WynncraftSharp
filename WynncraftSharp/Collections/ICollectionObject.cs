using WynncraftSharp.Requests;

namespace WynncraftSharp.Collections;

public interface ICollectionObject<out T> : IEnumerable<T> where T : IWynncraftRequestObject
{
    public string Endpoint { get; }
    public string DataName { get; }
}