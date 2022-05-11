using System.Threading.Tasks;
using NUnit.Framework;
using WynncraftSharp.Guilds;
using WynncraftSharp.User;

namespace WynncraftSharp.Tests;

public class Tests
{

    private IWynncraftApiClient _apiClient;
    
    [SetUp]
    public void Setup()
    {
        _apiClient = new WynncraftApiClientBuilder().Build();
    }

    [Test]
    public async Task Test1()
    {
        //Guild d = await _apiClient.GetGuildAsync("Avicia");
        Player p = await _apiClient.GetPlayerAsync("PHOENIXMAINWIKI");
        Assert.Pass();
    }

    //Although synchronous methods are supported, it is recommended to use async
    public async Task Example()
    {
        IWynncraftApiClientBuilder builder = new WynncraftApiClientBuilder();
        //Perform client configuration here such logging (uses Microsoft's abstraction)
        IWynncraftApiClient client = builder.Build(); 
        //Now use any of your favourite wynncraft API methods with ease!
        Guild guild = await client.GetGuildAsync("Gasmask");
    }
}