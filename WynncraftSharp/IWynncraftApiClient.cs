using WynncraftSharp.Requests;

namespace WynncraftSharp;

public interface IWynncraftApiClient
{
    public Task<T> GetAsync<T>(string command = "") where T : class, IRequestObject;
    public T Get<T>(string command = "") where T : class, IRequestObject;
}