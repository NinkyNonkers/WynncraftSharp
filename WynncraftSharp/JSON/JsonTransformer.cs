using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WynncraftSharp.Requests;
using WynncraftSharp.Requests.Objects;

namespace WynncraftSharp.JSON;

public class JsonTransformer<TTarget> where TTarget : class, IRequestObject
{
    private readonly string _json;
    private readonly JsonSerializerSettings _settings;
    private readonly TTarget _result;

    public JsonTransformer(TTarget result, string json)
    {
        _result = result;
        _json = json;
        _settings = new JsonSerializerSettings();
        _settings.Converters.Add(new RequestObjectConverter());
        _settings.Formatting = Formatting.Indented;
        _settings.ContractResolver = new RequestObjectResolver();
    }

    public TTarget Transform()
    {
        JObject json = JObject.Parse(_json);
        json.CheckJson();
        JObject obj = new JObject {{"RequestObject", json}};
        RequestObjectWrapper<TTarget> wrapper = new RequestObjectWrapper<TTarget>(_result);
        JsonConvert.PopulateObject(obj.ToString(), wrapper, _settings);
        return wrapper.RequestObject;
    }
}