using WynncraftSharp.API.Requests;
using WynncraftSharp.API.Versioning;

namespace WynncraftSharp.API;

public static class WynncraftService
{
    public const string LegacyBaseUrl = "https://api.wynncraft.com/";
    public const string Version3BaseUrl = "https://web-api.wynncraft.com/";

    private const string LegacyEndpoint = "public_api.php";
    private const string V2Endpoint = "v2/";
    private const string V3Endpoint = "api/v3/";
    
    
    public static string GetApiUrl(this ApiVersion version)
    {
        switch (version)
        {
            default:
            case ApiVersion.Legacy:
                return LegacyBaseUrl + LegacyEndpoint;
            case ApiVersion.V2:
                return LegacyBaseUrl + V2Endpoint;
            case ApiVersion.V3:
                return Version3BaseUrl + V3Endpoint;
        }
    }
    

    internal static string GenerateCommandUrl(this IRequest obj, string command = "")
    {
        string result = obj.ApiVersion.GetApiUrl();
        
        if (obj.ApiVersion.IsLatest())
        {
            result += obj.Endpoint;
            if (command != "")
                result += "/" + command;
            return result;
        }

        result += $"?action={obj.Endpoint}";
        if (command != "")
            result += "&command=" + command;
        return result;
    }

    internal static string GenerateParameterUrl(this IRequest obj, params RequestParameter[] parameters)
    {
        string result = obj.ApiVersion.GetApiUrl();
        if (obj.ApiVersion.IsLatest())
        {
            result += obj.Endpoint;
            foreach (RequestParameter param in parameters)
                result += param.ToParameter(obj.ApiVersion, false);
            return result;
        }

        result += $"?action={obj.Endpoint}";
        
        foreach (RequestParameter param in parameters)
            result += param.ToParameter(obj.ApiVersion, false);
        
        return result;
    }

    public const string WynncraftWebsite = "https://wynncraft.com/";
    
}