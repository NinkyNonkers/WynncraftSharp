using WynncraftSharp.Requests;
using WynncraftSharp.Requests.Objects;

namespace WynncraftSharp;

public interface IWynncraftApiClient
{
    public Task<T> GetAsync<T>(string command = "", bool wrap = true) where T : class, IRequest;
    public T Get<T>(string command = "", bool wrap = true) where T : class, IRequest;
    public Task<T> GetWithParametersAsync<T>(bool wrap = true, params RequestParameter[] para) where T : class, IRequest;
}