using Newtonsoft.Json;

namespace WynncraftSharp.Requests;

public abstract class RequestObjectBase : IRequestObject
{
    [JsonIgnore] public string Endpoint { get;  }
    [JsonIgnore] public string DataObjectName { get; protected set; } = "data";

    [JsonIgnore] public ApiVersion ExpectedApiVersion { get; protected set; } = ApiVersion.V2;

    protected IWynncraftApiClient Client { get; }

    protected RequestObjectBase(IWynncraftApiClient client, string endpoint, string dataObjectName)
    {
        Client = client;
        Endpoint = endpoint;
        DataObjectName = dataObjectName;
    }
    
    protected RequestObjectBase(IWynncraftApiClient client, string endpoint)
    {
        Client = client;
        Endpoint = endpoint;
    }
    
}