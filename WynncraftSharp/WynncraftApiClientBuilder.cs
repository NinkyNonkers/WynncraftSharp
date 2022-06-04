using Microsoft.Extensions.Logging;

namespace WynncraftSharp;

public class WynncraftApiClientBuilder : IWynncraftApiClientBuilder
{

    private ILoggerFactory _factory;
    private readonly ClientConfiguration _config;

    public WynncraftApiClientBuilder()
    {
        _factory = LoggerFactory.Create(a => a.AddSimpleConsole());
        _config = new ClientConfiguration();
    }
    
    public IWynncraftApiClientBuilder ConfigureLogging(Action<ILoggerFactory> factory)
    {
        factory(_factory);
        return this;
    }
    
    public IWynncraftApiClientBuilder AddLoggingProvider(ILoggerProvider provider)
    {
        _factory.AddProvider(provider);
        return this;
    }

    public IWynncraftApiClientBuilder WithLoggerFactory(ILoggerFactory factory)
    {
        _factory = factory;
        return this;
    }

    public IWynncraftApiClientBuilder ConfigureClient(Action<ClientConfiguration> config)
    {
        config(_config);
        return this;
    }

    public IWynncraftApiClient Build()
    {
        return new WynncraftApiClient(_factory, _config);
    }
}