using Newtonsoft.Json;
using WynncraftSharp.API.Versioning;

namespace WynncraftSharp.API.Requests.Objects;

/// <summary>
/// Base class for non-enumerable, singular objects
/// </summary>
public abstract class RequestObjectBase : RequestBase, IRequestObject
{
    [JsonIgnore] public string DataObjectName { get; protected set; } = "data";


    /// <summary>
    /// Base class for non-enumerable, singular objects
    /// </summary>
    /// <param name="client"></param>
    /// <param name="endpoint"></param>
    /// <param name="dataObjectName">The JSON key of the object returned (default is "data")</param>
    protected RequestObjectBase(IWynncraftApiClient client, string endpoint, string dataObjectName) : base(client, endpoint)
    {
        DataObjectName = dataObjectName;
    }

    protected RequestObjectBase(IWynncraftApiClient client, string endpoint) : base(client, endpoint)
    {
    }

    protected RequestObjectBase(IWynncraftApiClient client, VersionedEndpoint endpoint) : base(client, endpoint)
    {
    }
    
    protected RequestObjectBase(IWynncraftApiClient client, VersionedEndpoint endpoint, string dataObjectName) : base(client, endpoint)
    {
        DataObjectName = dataObjectName;
    }

}