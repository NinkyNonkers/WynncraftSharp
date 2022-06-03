using Newtonsoft.Json;
using WynncraftSharp.API.JSON;

namespace WynncraftSharp.API.Requests.Objects;


[JsonConverter(typeof(RequestObjectConverter))]
public interface IRequestObject : IRequest
{
    [JsonIgnore] public string DataObjectName { get; }
}