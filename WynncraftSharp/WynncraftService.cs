using WynncraftSharp.Requests;
using WynncraftSharp.Requests.Versions;

namespace WynncraftSharp;

public static class WynncraftService
{
    public const string BaseUrl = "https://api.wynncraft.com/public_api.php";
    
    public static string GenerateActionUrl(IWynncraftRequestObject obj, string command = "")
    {
        if (obj.ExpectedApiVersion == ApiVersion.V2)
        {
            string result = BaseUrl + "/" + obj.Endpoint;
            if (command != "")
                result += "/" + command;
            return result;
        }
        return BaseUrl + $"?action={obj.Endpoint}";
    }

    public const string WynncraftWebsite = "https://wynncraft.com";

}