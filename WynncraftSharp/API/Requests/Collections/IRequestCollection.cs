namespace WynncraftSharp.API.Requests.Collections;

public interface IRequestCollection : IRequest
{
    
}

public interface IRequestCollection<out T> : IEnumerable<T>, IRequestCollection
{
    public string DataName { get; }
}