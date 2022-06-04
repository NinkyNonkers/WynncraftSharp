using Newtonsoft.Json;
using WynncraftSharp.API.Versioning;

namespace WynncraftSharp.API.Requests;

public interface IRequest : IApiElement
{
    [JsonIgnore] public string Endpoint { get; }
    [JsonIgnore] public ApiVersion ExpectedApiVersion { get; }
    [JsonIgnore] public ApiVersion PreferredApiVersion { get; set; }
    [JsonIgnore] public ApiVersion ApiVersion { get; }
    [JsonIgnore] public RequestType ExpectedRequestType { get; internal set; }

}