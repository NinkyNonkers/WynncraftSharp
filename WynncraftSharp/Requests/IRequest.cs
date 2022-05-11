using Newtonsoft.Json;

namespace WynncraftSharp.Requests;

public interface IRequest
{
    [JsonIgnore] public string Endpoint { get; }
}