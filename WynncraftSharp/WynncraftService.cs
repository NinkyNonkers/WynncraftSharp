using WynncraftSharp.Requests;
using WynncraftSharp.Requests.Versions;

namespace WynncraftSharp;

public static class WynncraftService
{
    public const string BaseUrl = "https://api.wynncraft.com/public_api.php";
    
    public static string GenerateActionUrl(IWynncraftRequestObject obj, string command = "")
    {
        string result;
        if (obj.ExpectedApiVersion == ApiVersion.V2)
        {
            result = BaseUrl + "/" + obj.Endpoint;
            if (command != "")
                result += "/" + command;
            return result;
        }
        result = BaseUrl + $"?action={obj.Endpoint}";
        if (command != "")
            result += "&command=" + command;
        return result;
    }

    public const string WynncraftWebsite = "https://wynncraft.com";

}