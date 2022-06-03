using Newtonsoft.Json;
using WynncraftSharp.API.Versioning;

namespace WynncraftSharp.API.Requests;

public interface IRequest
{
    [JsonIgnore] public string Endpoint { get; }
    [JsonIgnore] public ApiVersion ExpectedApiVersion { get; }
    [JsonIgnore] public ApiVersion PreferredApiVersion { get; set; }
    [JsonIgnore] public ApiVersion ApiVersion { get; }

}