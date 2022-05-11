using Newtonsoft.Json;
using WynncraftSharp.Requests.Versions;

namespace WynncraftSharp.Requests;

public abstract class WynncraftRequestObjectBase : IWynncraftRequestObject
{
    [JsonIgnore] public string Endpoint { get;  }
    [JsonIgnore] public string DataObjectName { get; protected set; } = "data";

    [JsonIgnore] public ApiVersion ExpectedApiVersion { get; protected set; } = ApiVersion.V2;

    protected IWynncraftApiClient Client { get; }

    protected WynncraftRequestObjectBase(IWynncraftApiClient client, string endpoint, string dataObjectName)
    {
        Client = client;
        Endpoint = endpoint;
        DataObjectName = dataObjectName;
    }
    
    protected WynncraftRequestObjectBase(IWynncraftApiClient client, string endpoint)
    {
        Client = client;
        Endpoint = endpoint;
    }
    
}