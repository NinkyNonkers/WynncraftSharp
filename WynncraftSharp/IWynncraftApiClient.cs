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
    public Task<T> GetAsync<T>(string command = "", bool wrap = true) where T : class, IRequest;
    
    /// <summary>
    /// Gets a request object from the Wynncraft API (synchronous)
    /// </summary>
    /// <param name="command"></param>
    /// <param name="wrap"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public T Get<T>(string command = "", bool wrap = true) where T : class, IRequest;
    
    /// <summary>
    /// Gets a request object from the Wynncraft API with parameters (better for multiple arguments)
    /// </summary>
    /// <param name="para"></param>
    /// <param name="wrap"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public Task<T> GetWithParametersAsync<T>(bool wrap = true, params RequestParameter[] para) where T : class, IRequest;
}