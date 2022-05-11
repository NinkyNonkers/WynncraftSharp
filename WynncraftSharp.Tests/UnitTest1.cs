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
        Guild d = await _apiClient.GetGuildAsync("Avicia");
        Player p = await _apiClient.GetPlayerAsync("lovewiki");
        if (d.Request.Version == 2)
            Assert.Pass();
        Assert.Pass();
    }
}