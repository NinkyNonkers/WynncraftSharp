using WynncraftSharp.Requests.Objects;

namespace WynncraftSharp.Requests.Collections;

public interface IRequestCollection
{
    
}

public interface IRequestCollection<out T> : IEnumerable<T>, IRequestCollection, IRequest
{
    public string DataName { get; }
}