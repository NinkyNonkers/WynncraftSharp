using Microsoft.Extensions.Logging;
using WynncraftSharp.API.Requests;

namespace WynncraftSharp;

public interface IWynncraftApiClient
{
    internal ILogger<IWynncraftApiClient> Logger { get; }

    /// <summary>
    /// Gets a request object from the Wynncraft API
    /// </summary>
    /// <param name="command"></param>
    /// <param name="wrap"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public Task<T> GetAsync<T>(bool wrap = true, params RequestParameter[] data) where T : class, IRequest;
    public Task<T> GetAsync<T>(RequestParameter[] data, bool wrap = true) where T : class, IRequest;
    
    public Task<T> GetAsync<T>(RequestParameter data, bool wrap = true) where T : class, IRequest;
    public Task<T> GetAsync<T>(bool wrap = true) where T : class, IRequest;

    public Task<T> GetExtensionAsync<T>(IRequest original, string extension, bool wrap = true,
        params RequestParameter[] param) where T : class, new();

}