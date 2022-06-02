using Newtonsoft.Json;

namespace WynncraftSharp.API.Requests.Objects;

public abstract class RequestObjectBase : RequestBase, IRequestObject
{
    [JsonIgnore] public override string Endpoint { get;  }
    [JsonIgnore] public string DataObjectName { get; protected set; } = "data";

    protected IWynncraftApiClient Client { get; }

    protected RequestObjectBase(IWynncraftApiClient client, string endpoint, string dataObjectName) : base(client)
    {
        Client = client;
        Endpoint = endpoint;
        DataObjectName = dataObjectName;
    }

    protected RequestObjectBase(IWynncraftApiClient client, string endpoint) : base(client)
    {
        Client = client;
        Endpoint = endpoint;
    }

}