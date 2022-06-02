using System.Net.Http.Headers;
using System.Reflection;
using System.Web;
using Microsoft.Extensions.Logging;
using WynncraftSharp.API;
using WynncraftSharp.API.JSON;
using WynncraftSharp.API.Requests;
using WynncraftSharp.API.Versioning;

namespace WynncraftSharp;

public class WynncraftApiClient : IWynncraftApiClient
{
    
    /*
     * TODO:
     * 
     * Improve IRequest to have parameter defaults built-in
     * Finish implementing the remaining api methods
     */
    
    private readonly HttpClient _client;
    private readonly ApiVersion _versionPreference;
    private readonly ILoggerFactory _loggerFactory;
    
    private readonly ILogger<WynncraftApiClient> _logger;

    private const string Agent = "WynncraftSharp";

    public WynncraftApiClient(ApiVersion preference = ApiVersion.V2)
    {
        _versionPreference = preference;
        _client = new HttpClient();
        _loggerFactory = new LoggerFactory();
        _logger = _loggerFactory.CreateLogger<WynncraftApiClient>();
        _client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(Agent, Assembly.GetCallingAssembly().GetName().Version.ToString()));
    }

    internal WynncraftApiClient(ILoggerFactory factory, ApiVersion preference = ApiVersion.V2)
    {
        _loggerFactory = factory;
        _versionPreference = preference;
        _logger = _loggerFactory.CreateLogger<WynncraftApiClient>();
        _client = new HttpClient();
        _client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(Agent, Assembly.GetCallingAssembly().GetName().Version.ToString()));
    }
    
    ILogger<IWynncraftApiClient> IWynncraftApiClient.Logger => _logger;

    
    public async Task<T> GetAsync<T>(string command = "", bool wrap = true) where T : class, IRequest
    {
        try
        {
            Type t = typeof(T);
            _logger.LogDebug("Beginning Request cycle: {Cycle}", t.Name);
            T r = (T) Activator.CreateInstance(t, this);
            r.PreferredApiVersion = _versionPreference;
            _logger.LogDebug("Generating URL with 'command-action' type");
            string requestUrl = r.GenerateCommandUrl(command);
            return await GetInternalAsync(r, requestUrl, wrap);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Could not request the Wynncraft API!");
            throw;
        }
        
    }
    
    public T Get<T>(string command = "", bool wrap = true) where T : class, IRequest
    {
        try
        {
            Type t = typeof(T);
            _logger.LogDebug("Beginning Request cycle: {Cycle}", t.Name);
            T r = (T) Activator.CreateInstance(typeof(T), this);
            r.PreferredApiVersion = _versionPreference;
            _logger.LogDebug("Generating URL with 'command-action' type");
            string requestUrl = r.GenerateCommandUrl();
            return GetInternalAsync(r, requestUrl, wrap).Result;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Could not request the Wynncraft API!");
            throw;
        }
    }

    public async Task<T> GetWithParametersAsync<T>(bool wrap = true, params RequestParameter[] para) where T : class, IRequest
    {
        try
        {
            Type t = typeof(T);
            _logger.LogDebug("Beginning Request cycle: {Cycle}", t.Name);
            T r = (T) Activator.CreateInstance(typeof(T), this);
            r.PreferredApiVersion = _versionPreference;
            _logger.LogDebug("Generating URL with 'parameter' type");
            string requestUrl = r.GenerateParameterUrl(para);
            return await GetInternalAsync(r, requestUrl, wrap);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Could not request the WYnncraft API");
            throw;
        }
    }
    
    
    private async Task<T> GetInternalAsync<T>(T currentValue, string url, bool wrap) where T : class, IRequest
    {
        _logger.LogDebug("Requesting Wynncraft API with URL {Url}", url);
        HttpResponseMessage message = await _client.GetAsync(HttpUtility.UrlEncode(url));
        message.EnsureSuccessStatusCode();
        _logger.LogInformation("Received response from Wynncraft API");
        _logger.LogDebug("Transforming response JSON to request object");
        JsonTransformer<T> jsonTransformer = new JsonTransformer<T>(currentValue, await message.Content.ReadAsStringAsync(),
            _loggerFactory.CreateLogger<JsonTransformer<T>>(), wrap);
        return jsonTransformer.Transform();
    }
}