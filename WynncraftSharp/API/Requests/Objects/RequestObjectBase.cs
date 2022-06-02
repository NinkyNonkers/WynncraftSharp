using Newtonsoft.Json;
using WynncraftSharp.API.Versioning;

namespace WynncraftSharp.API.Requests.Objects;

public abstract class RequestObjectBase : RequestBase, IRequestObject
{
    [JsonIgnore] public string DataObjectName { get; protected set; } = "data";


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