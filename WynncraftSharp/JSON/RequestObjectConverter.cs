using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WynncraftSharp.Requests;

namespace WynncraftSharp.JSON;

public class RequestObjectConverter : JsonConverter<IRequestObject>
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

    public override void WriteJson(JsonWriter writer, IRequestObject? value, JsonSerializer serializer)
    {
        //unrequired
        throw new NotImplementedException();
    }

    public override IRequestObject? ReadJson(JsonReader reader, Type objectType, IRequestObject? existingValue,
        bool hasExistingValue, JsonSerializer serializer)
    {
        if (existingValue == null)
            throw new NotImplementedException();
        JObject obj = JObject.Load(reader);
        var exists = obj.ContainsKey(existingValue.DataObjectName);
        var dataObj = !exists ? obj.ToString() : obj[existingValue.DataObjectName]!.RequestDataToObject().ToString();
        //prevent looping
        JsonConvert.PopulateObject(dataObj, existingValue, _settings);

        if (!exists) return existingValue;
        
        //populate request meta fields for V2
        obj.Remove(existingValue.DataObjectName);
        JsonConvert.PopulateObject(obj.ToString(), existingValue, _settings); 

        return existingValue;
    }
}