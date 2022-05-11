using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WynncraftSharp.Requests;

namespace WynncraftSharp.JSON;

public class RequestObjectConverter : JsonConverter<IWynncraftRequestObject>
{
    public override bool CanWrite { get; } = false;

    private readonly JsonSerializerSettings _settings;

    public RequestObjectConverter()
    {
        _settings = new JsonSerializerSettings
        {
            ContractResolver = new RequestObjectResolver()
        };
    }

    public override void WriteJson(JsonWriter writer, IWynncraftRequestObject? value, JsonSerializer serializer)
    {
        //unrequired
        throw new NotImplementedException();
    }

    public override IWynncraftRequestObject? ReadJson(JsonReader reader, Type objectType, IWynncraftRequestObject? existingValue,
        bool hasExistingValue, JsonSerializer serializer)
    {
        if (existingValue == null)
            throw new NotImplementedException();
        JObject obj = JObject.Load(reader);
        var exists = obj.ContainsKey(existingValue.DataObjectName);
        var dataObj = !exists ? obj.ToString() : obj[existingValue.DataObjectName]!.ToString();
        //prevent looping
        JsonConvert.PopulateObject(dataObj, existingValue, _settings);
        return existingValue;
    }
}