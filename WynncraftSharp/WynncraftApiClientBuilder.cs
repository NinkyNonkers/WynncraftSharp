using Microsoft.Extensions.Logging;
using WynncraftSharp.Requests.Versions;

namespace WynncraftSharp;

public class WynncraftApiClientBuilder : IWynncraftApiClientBuilder
{

    private ApiVersion _versionPreference = ApiVersion.V2;
    private ILoggerFactory _factory;

    public WynncraftApiClientBuilder()
    {
        _factory = LoggerFactory.Create(a => a.AddSimpleConsole());
    }
    
    public IWynncraftApiClientBuilder WithVersionPreference(ApiVersion preference)
    {
        _versionPreference = preference;
        return this;
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

    public IWynncraftApiClient Build()
    {
        return new WynncraftApiClient(_factory, _versionPreference);
    }
}