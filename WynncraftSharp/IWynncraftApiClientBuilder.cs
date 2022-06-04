using Microsoft.Extensions.Logging;
using WynncraftSharp.API.Versioning;

namespace WynncraftSharp;

public interface IWynncraftApiClientBuilder
{
    public IWynncraftApiClientBuilder ConfigureLogging(Action<ILoggerFactory> factory);
    public IWynncraftApiClientBuilder AddLoggingProvider(ILoggerProvider provider);
    public IWynncraftApiClientBuilder WithLoggerFactory(ILoggerFactory factory);
    public IWynncraftApiClientBuilder ConfigureClient(Action<ClientConfiguration> config);
    public IWynncraftApiClient Build();
}