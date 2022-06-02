using Newtonsoft.Json.Linq;

namespace WynncraftSharp.API.JSON;

public static class JsonExtensions
{
    public static JObject RequestDataToObject(this JToken token)
    {
        JArray? array = token as JArray;
        if (array == null)
            throw new Exception("Incorrect Wynncraft V2 data format!");
        JToken obj = array[0];
        return obj.ToObject<JObject>();
    }
    public static void CheckJson(this JObject json)
    {
        if (json.ContainsKey("error"))
            throw new Exception("Response indicated an error: " + json["error"]);
        if (json.ContainsKey("status"))
        {
            string s = json["status"]!.ToString();
            switch (s)
            {
                case "404":
                    throw new MissingMethodException("Could not find this method on Wynncraft API: " + json["status"]);
                case "400":
                    throw new Exception("Could not find that object!");
            }
        }
        if (!json.ContainsKey("code")) return;
        {
            string s = json["code"]!.ToString();
            switch (s)
            {
                case "404":
                    throw new MissingMethodException("Could not find this method on Wynncraft API: " + json["status"]);
                case "400":
                    throw new Exception("Could not find that object!");
            }
        }
    }
}