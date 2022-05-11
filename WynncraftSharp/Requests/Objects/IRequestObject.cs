using Newtonsoft.Json;
using WynncraftSharp.JSON;

namespace WynncraftSharp.Requests.Objects;


[JsonConverter(typeof(RequestObjectConverter))]
public interface IRequestObject : IRequest
{
    [JsonIgnore] public string DataObjectName { get; }
    [JsonIgnore] public ApiVersion ExpectedApiVersion { get; }
}