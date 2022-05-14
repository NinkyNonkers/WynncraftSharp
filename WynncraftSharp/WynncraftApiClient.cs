﻿using System.Net.Http.Headers;
using System.Reflection;
using Microsoft.Extensions.Logging;
using WynncraftSharp.JSON;
using WynncraftSharp.Requests;

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
            T t = (T) Activator.CreateInstance(typeof(T), this);
            string requestUrl = WynncraftService.GenerateCommandUrl(t, command);
            return await GetInternalAsync(t, requestUrl, wrap);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Could not request the Wynncraft API!");
            throw;
        }
        
    }
    
    private async Task<T> GetInternalAsync<T>(T currentValue, string url, bool wrap) where T : class, IRequest
    {
        HttpResponseMessage message = await _client.GetAsync(url);
        message.EnsureSuccessStatusCode();
        JsonTransformer<T> jsonTransformer = new JsonTransformer<T>(currentValue, await message.Content.ReadAsStringAsync(), wrap);
        return jsonTransformer.Transform();
    }
    
    public T Get<T>(string command = "", bool wrap = true) where T : class, IRequest
    {
        try
        {
            T t = (T) Activator.CreateInstance(typeof(T), this);
            string requestUrl = WynncraftService.GenerateCommandUrl(t, command);
            return GetInternalAsync(t, requestUrl, wrap).Result;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Could not request the Wynncraft API!");
            throw;
        }
    }

    public async Task<T> GetWithParametersAsync<T>(bool wrap = true, params RequestParameter[] para) where T : class, IRequest
    {
        T t = (T) Activator.CreateInstance(typeof(T), this);
        string requestUrl = WynncraftService.GenerateUrl(t, para);
        return await GetInternalAsync(t, requestUrl, wrap);
    }
}