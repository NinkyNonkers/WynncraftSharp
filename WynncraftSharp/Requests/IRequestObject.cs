using Newtonsoft.Json;
using WynncraftSharp.JSON;
using WynncraftSharp.Requests.Versions;

namespace WynncraftSharp.Requests;


[JsonConverter(typeof(RequestObjectConverter))]
public interface IRequestObject
{
    [JsonIgnore] public string Endpoint { get; }
    [JsonIgnore] public string DataObjectName { get; }
    [JsonIgnore] public ApiVersion ExpectedApiVersion { get; }
}