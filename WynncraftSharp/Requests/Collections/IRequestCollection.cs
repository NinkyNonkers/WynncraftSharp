using WynncraftSharp.Requests.Objects;

namespace WynncraftSharp.Requests.Collections;

public interface IRequestCollection<out T> : IEnumerable<T>, IRequest where T : IRequestObject
{
    public string DataName { get; }
}