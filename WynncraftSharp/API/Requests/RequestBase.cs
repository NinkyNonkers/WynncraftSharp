using Newtonsoft.Json;
using WynncraftSharp.API.Versioning;

namespace WynncraftSharp.API.Requests;

public abstract class RequestBase : IRequest
{
    protected RequestBase(IWynncraftApiClient client, string endpoint)
    {
        Client = client;
        VersionedEndpoint = new VersionedEndpoint();
        VersionedEndpoint.LoadSingleEndpoint(endpoint, PreferredApiVersion);
    }

    protected RequestBase(IWynncraftApiClient client, VersionedEndpoint endpoint)
    {
        Client = client;
        VersionedEndpoint = endpoint;
    }
    
    public string Endpoint
    {
        get => VersionedEndpoint.DetermineEndpoint(ApiVersion);
    }
    
    public ApiVersion ExpectedApiVersion 
    { 
        get => ApiVersion;
        protected set => ApiVersion = value;
    }
    
    public ApiVersion PreferredApiVersion
    {
        get => ApiVersion;
        set
        {
            if (value.IsLatest() && ApiVersion.IsLatest())
                ApiVersion = value;
        }
    }
    public ApiVersion ApiVersion { get; private set; }
    [JsonIgnore] protected IWynncraftApiClient Client { get; }
    
    [JsonIgnore] protected bool IsCrossVersion { get; set; }
    [JsonIgnore] protected VersionedEndpoint VersionedEndpoint { get; set; }
    
}