using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WynncraftSharp.API.Requests;

namespace WynncraftSharp.API.JSON;

public class JsonTransformer<TTarget> where TTarget : class, IRequest
{
    private readonly string _json;
    private readonly JsonSerializerSettings _settings;
    private readonly TTarget _result;
    private readonly bool _wrap;
    private readonly ILogger<JsonTransformer<TTarget>> _logger;

    internal JsonTransformer(TTarget result, string json, ILogger<JsonTransformer<TTarget>> logger, bool wrap = true)
    {
        _result = result;
        _json = json;
        _logger = logger;
        _settings = new JsonSerializerSettings();
        _settings.Converters.Add(new RequestObjectConverter());
        _settings.Formatting = Formatting.Indented;
        _settings.ContractResolver = new RequestObjectResolver();
        _wrap = wrap;
    }

    public TTarget Transform()
    {
        try
        {
            _logger.LogDebug("Parsing: pass 1");
            JObject json = JObject.Parse(_json);
            _logger.LogDebug("Checking JSON for errors");
            json.CheckJson();
            if (!_wrap)
            {
                _logger.LogDebug("Populating request object");
                JsonConvert.PopulateObject(json.ToString(), _result, _settings);
                return _result;
            }
            _logger.LogDebug("Parsing: pass 2");
            JObject obj = new JObject {{"RequestObject", json}};
            _logger.LogDebug("Populating request object with wrapping");
            RequestWrapper<TTarget> wrapper = new RequestWrapper<TTarget>(_result);
            JsonConvert.PopulateObject(obj.ToString(), wrapper, _settings);
            return wrapper.Request;
        }
        catch (Exception e)
        {
            _logger.LogError("{e}", e);
        }

        return _result;
    }
}