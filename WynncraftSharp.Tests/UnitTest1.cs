using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;
using WynncraftSharp.Guilds;
using WynncraftSharp.Items;
using WynncraftSharp.Recipes;
using WynncraftSharp.Search;

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
        IEnumerable<Item> items = await _apiClient.SearchItemsByNameAsync("staff");
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
        IEnumerable<Item> items = await client.SearchItemsByNameAsync("staff");
    }
}