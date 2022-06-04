using Newtonsoft.Json;
using WynncraftSharp.API.Versioning;

namespace WynncraftSharp.API.Requests;

/// <summary>
/// Base class for all Requests
/// </summary>
public abstract class RequestBase : IRequest
{
    /// <summary>
    /// Base class for all Requests
    /// </summary>
    /// <param name="client"></param>
    /// <param name="endpoint"></param>
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
            if (value == ApiVersion.V3 && ApiVersion == ApiVersion.Legacy && IsCrossVersion)
                ApiVersion = value;
            else if (value.IsLatest() && ApiVersion.IsLatest() && IsCrossVersion)
                ApiVersion = value;
        }
    }
    public ApiVersion ApiVersion { get; private set; }
    
    RequestType IRequest.ExpectedRequestType { get; set; }
    
    [JsonIgnore] protected IWynncraftApiClient Client { get; }
    [JsonIgnore] protected bool IsCrossVersion { get; set; }
    [JsonIgnore] protected VersionedEndpoint VersionedEndpoint { get; set; }
    
}