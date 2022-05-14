using Microsoft.Extensions.Logging;
using WynncraftSharp.Requests;
using WynncraftSharp.Requests.Objects;

namespace WynncraftSharp;

public interface IWynncraftApiClient
{
    
    internal ILogger<IWynncraftApiClient> Logger { get; }

    public Task<T> GetAsync<T>(string command = "", bool wrap = true) where T : class, IRequest;
    public T Get<T>(string command = "", bool wrap = true) where T : class, IRequest;
    public Task<T> GetWithParametersAsync<T>(bool wrap = true, params RequestParameter[] para) where T : class, IRequest;
}