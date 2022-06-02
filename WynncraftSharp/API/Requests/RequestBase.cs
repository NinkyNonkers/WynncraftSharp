using Newtonsoft.Json;
using WynncraftSharp.API.Versioning;

namespace WynncraftSharp.API.Requests;

public abstract class RequestBase : IRequest
{
    protected RequestBase(IWynncraftApiClient client)
    {
        Client = client;
    }

    public abstract string Endpoint { get; }
    public ApiVersion ExpectedApiVersion { get; protected set; }
    public ApiVersion PreferredApiVersion
    {
        get => ApiVersion;
        set
        {
            if (value.IsLatest() && ExpectedApiVersion.IsLatest())
                ApiVersion = value;
        }
    }
    public ApiVersion ApiVersion { get; private set; }
    [JsonIgnore] protected IWynncraftApiClient Client { get; }

}