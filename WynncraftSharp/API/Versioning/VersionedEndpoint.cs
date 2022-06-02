namespace WynncraftSharp.API.Versioning;

public class VersionedEndpoint
{
    public string Legacy { get; set; }
    public string V2 { get; set; }
    public string Original { get; set; }
    public string WebApi { get; set; }

    public string DetermineEndpoint(ApiVersion version)
    {
        switch (version)
        {
            case ApiVersion.Legacy:
                return !string.IsNullOrEmpty(Legacy) ? Legacy : Original;
            default:
            case ApiVersion.V2:
                return !string.IsNullOrEmpty(V2) ? V2 : Original;
            case ApiVersion.V3:
                return WebApi;
        }
    }

    public void LoadSingleEndpoint(string endpoint, ApiVersion version)
    {
        switch (version)
        {
            case ApiVersion.Legacy:
                Legacy = endpoint;
                Original = endpoint;
                break;
            case ApiVersion.V2:
                V2 = endpoint;
                Original = endpoint;
                break;
            case ApiVersion.V3:
                WebApi = endpoint;
                break;
        }
    }
    
}