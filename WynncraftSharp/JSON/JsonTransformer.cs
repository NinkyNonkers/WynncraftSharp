using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WynncraftSharp.Requests;
using WynncraftSharp.Requests.Collections;

namespace WynncraftSharp.JSON;

public class JsonTransformer<TTarget> where TTarget : class, IRequest
{
    private readonly string _json;
    private readonly JsonSerializerSettings _settings;
    private readonly TTarget _result;
    private readonly bool _wrap;

    public JsonTransformer(TTarget result, string json, bool wrap = true)
    {
        _result = result;
        _json = json;
        _settings = new JsonSerializerSettings();
        _settings.Converters.Add(new RequestObjectConverter());
        _settings.Formatting = Formatting.Indented;
        _settings.ContractResolver = new RequestObjectResolver();
        _wrap = wrap;
    }

    public TTarget Transform()
    {
        JObject json = JObject.Parse(_json);
        json.CheckJson();
        if (!_wrap)
        {
            JsonConvert.PopulateObject(json.ToString(), _result, _settings);
            return _result;
        }
        JObject obj = new JObject {{"RequestObject", json}};
        RequestWrapper<TTarget> wrapper = new RequestWrapper<TTarget>(_result);
        JsonConvert.PopulateObject(obj.ToString(), wrapper, _settings);
        return wrapper.Request;
    }
}