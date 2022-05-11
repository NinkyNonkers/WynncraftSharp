using WynncraftSharp.Requests;
using WynncraftSharp.Requests.Objects;

namespace WynncraftSharp;

public static class WynncraftService
{
    public const string BaseUrl = "https://api.wynncraft.com/";

    private const string LegacyEndpoint = "public_api.php";
    private const string LatestEndpoint = "v2/";

    public static string GenerateCommandUrl(IRequestObject obj, string command = "")
    {
        string result;
        if (obj.ExpectedApiVersion == ApiVersion.V2)
        {
            result = BaseUrl + LatestEndpoint + obj.Endpoint;
            if (command != "")
                result += "/" + command;
            return result;
        }

        result = BaseUrl + LegacyEndpoint + $"?action={obj.Endpoint}";
        if (command != "")
            result += "&command=" + command;
        return result;
    }

    public static string GenerateUrl(IRequestObject obj, params RequestParameter[] parameters)
    {
        string result;
        if (obj.ExpectedApiVersion == ApiVersion.V2)
        {
            result = BaseUrl + LatestEndpoint + obj.Endpoint;
            
            return result;
        }

        result = BaseUrl + LegacyEndpoint + $"?action={obj.Endpoint}";


        foreach (RequestParameter param in parameters)
            result += param.ToParameter(false);

        return result;
    }

    public const string WynncraftWebsite = "https://wynncraft.com";

}