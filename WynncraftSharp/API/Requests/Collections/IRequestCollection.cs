namespace WynncraftSharp.API.Requests.Collections;

public interface IRequestCollection : IRequest
{
    
}

/// <summary>
/// A Request that is an enumerable type, typically a JsonArray
/// </summary>
/// <typeparam name="T">The type to be enumerated</typeparam>
public interface IRequestCollection<out T> : IEnumerable<T>, IRequestCollection
{
    public string DataName { get; }
}