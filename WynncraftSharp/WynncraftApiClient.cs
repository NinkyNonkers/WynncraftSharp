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

    public async Task<T> GetAsync<T>(bool wrap = true, params RequestParameter[] data)  where T : class, IRequest
    {
        Type t = typeof(T);
        _logger.LogDebug("Beginning Request cycle: {Cycle}", t.Name);
        T r = (T) Activator.CreateInstance(t, this);
        r.PreferredApiVersion = _versionPreference;
        switch (GetRequestType(r))
        {
            default:
            case RequestType.Action:
                return await GetWithActionAsync(r, data[0].ToCommand(), wrap);
            case RequestType.Parameter:
                return await GetWithParametersAsync(r, wrap, data);
        }
    }

    public async Task<T> GetAsync<T>(RequestParameter[] data, bool wrap = true) where T : class, IRequest
    {
        return await GetAsync<T>(wrap, data);
    }

    public async Task<T> GetAsync<T>(RequestParameter data, bool wrap = true) where T : class, IRequest
    {
        return await GetAsync<T>(wrap, data);
    }

    public async Task<T> GetAsync<T>(bool wrap = true) where T : class, IRequest
    {
        Type t = typeof(T);
        _logger.LogDebug("Beginning Request cycle: {Cycle}", t.Name);
        T r = (T) Activator.CreateInstance(t, this);
        r.PreferredApiVersion = _versionPreference;
        return await GetInternalAsync(r, r.GenerateCommandUrl(), wrap);
    }

    public async Task<T> GetExtensionAsync<T>(IRequest original, string extension, bool wrap = true, params RequestParameter[] param) where T : class, new()
    {
        Type t = typeof(T);
        _logger.LogDebug("Finding extension of {original}: {extension}", original.GetType().Name, t.Name);
        string url;
        switch (GetRequestType(original))
        {
            default:
            case RequestType.Action:
                url = original.GenerateCommandUrl() + extension;
                return await GetInternalAsync(new T(), url, wrap);
            case RequestType.Parameter:
                url = original.GenerateParameterUrl(param) + extension;
                return await GetInternalAsync(new T(), url, wrap);
        }
    }

    private static RequestType GetRequestType(IRequest rq)
    {
        switch (rq.ApiVersion)
        {
            case ApiVersion.V3:
                return RequestType.Parameter;
            default:
                return rq.ExpectedRequestType;
        }
    }
    
    private async Task<T> GetWithActionAsync<T>(T r, string command = "", bool wrap = true) where T : class, IRequest
    {
        try
        {
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

    private async Task<T> GetWithParametersAsync<T>(T r, bool wrap = true, params RequestParameter[] para) where T : class, IRequest
    {
        try
        {
            _logger.LogDebug("Generating URL with 'parameter' type");
            string requestUrl = r.GenerateParameterUrl(para);
            return await GetInternalAsync(r, requestUrl, wrap);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Could not request the Wynncraft API");
            throw;
        }
    }
    
    
    private async Task<T> GetInternalAsync<T>(T currentValue, string url, bool wrap) where T : class
    {
        _logger.LogDebug("Requesting Wynncraft API with URL {Url}", url);
        HttpResponseMessage message = await _client.GetAsync(HttpUtility.UrlEncode(url));
        message.EnsureSuccessStatusCode();
        _logger.LogDebug("Transforming response JSON to request object");
        JsonTransformer<T> jsonTransformer = new JsonTransformer<T>(currentValue, await message.Content.ReadAsStringAsync(),
            _loggerFactory.CreateLogger<JsonTransformer<T>>(), wrap);
        return jsonTransformer.Transform();
    }
}