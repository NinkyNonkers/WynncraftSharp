using Microsoft.Extensions.Logging;
using WynncraftSharp.API.Versioning;

namespace WynncraftSharp;

public interface IWynncraftApiClientBuilder
{
    public IWynncraftApiClientBuilder WithVersionPreference(ApiVersion preference);
    public IWynncraftApiClientBuilder ConfigureLogging(Action<ILoggerFactory> factory);
    public IWynncraftApiClientBuilder AddLoggingProvider(ILoggerProvider provider);
    public IWynncraftApiClientBuilder WithLoggerFactory(ILoggerFactory factory);
    public IWynncraftApiClient Build();
}