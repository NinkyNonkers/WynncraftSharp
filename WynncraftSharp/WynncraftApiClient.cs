using Microsoft.Extensions.Logging;
using WynncraftSharp.JSON;
using WynncraftSharp.Requests;
using WynncraftSharp.Requests.Versions;

namespace WynncraftSharp;

public class WynncraftApiClient : IWynncraftApiClient
{
    
    /*
     * TODO:
     * Improve request details wrapping for collections
     * Introduce cross-version requests and version preferences
     * Finish implementing the remaining api methods
     */
    
    private readonly HttpClient _client;
    private readonly ApiVersion _versionPreference;
    private readonly ILoggerFactory _loggerFactory;
    private readonly ILogger<WynncraftApiClient> _logger;

    public WynncraftApiClient(ApiVersion preference = ApiVersion.V2)
    {
        _versionPreference = preference;
        _client = new HttpClient();
        _loggerFactory = new LoggerFactory();
        _logger = _loggerFactory.CreateLogger<WynncraftApiClient>();
    }

    internal WynncraftApiClient(ILoggerFactory factory, ApiVersion preference = ApiVersion.V2)
    {
        _loggerFactory = factory;
        _versionPreference = preference;
        _logger = _loggerFactory.CreateLogger<WynncraftApiClient>();
        _client = new HttpClient();
    }
    
    public async Task<T> GetAsync<T>(string command = "") where T : class, IWynncraftRequestObject
    {
        try
        {
            T t = (T) Activator.CreateInstance(typeof(T), this);
            string requestUrl = WynncraftService.GenerateActionUrl(t, command);
            if (command != "")
                requestUrl += $"&command={command}";
            //no need for any other method yet
            HttpResponseMessage message = await _client.GetAsync(requestUrl);
            message.EnsureSuccessStatusCode();
            JsonTransformer<T> jsonTransformer =
                new JsonTransformer<T>(t, (await message.Content.ReadAsStringAsync()));
            return jsonTransformer.Transform();
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Could not request the Wynncraft API!");
            throw;
        }
        
    }

    public T Get<T>(string command = "") where T : class, IWynncraftRequestObject
    {
        try
        {
            T t = (T) Activator.CreateInstance(typeof(T), this);
            string requestUrl = WynncraftService.GenerateActionUrl(t, command);
            if (command != "")
                requestUrl += $"&command={command}";
            //no need for any other method yet
            HttpResponseMessage message = _client.GetAsync(requestUrl).Result;
            message.EnsureSuccessStatusCode();
            JsonTransformer<T> jsonTransformer =
                new JsonTransformer<T>(t, (message.Content.ReadAsStringAsync().Result));
            return jsonTransformer.Transform();
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Could not request the Wynncraft API!");
            throw;
        }
    }
}