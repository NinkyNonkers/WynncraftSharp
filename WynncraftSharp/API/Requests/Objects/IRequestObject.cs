using Newtonsoft.Json;
using WynncraftSharp.API.JSON;

namespace WynncraftSharp.API.Requests.Objects;

/// <summary>
/// Request that is a singular, non-enumerable type
/// </summary>
[JsonConverter(typeof(RequestObjectConverter))]
public interface IRequestObject : IRequest
{
    [JsonIgnore] public string DataObjectName { get; }
}