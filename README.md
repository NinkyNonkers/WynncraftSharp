# WynncraftSharp
Wynncraft API wrapped with delightful modern .NET practices, whilst remaining extremely user friendly.

## Getting started

````
    //Although synchronous methods are supported, it is recommended to use async
    public async Task Example()
    {
        //Whilst there is a constructor available on WynncraftApiClient, it is recommended to use builder
        IWynncraftApiClientBuilder builder = new WynncraftApiClientBuilder();
        //Perform client configuration here such logging (uses Microsoft's abstraction)
        IWynncraftApiClient client = builder.Build();
        //Now use any of your favourite wynncraft API methods with ease!
        Guild guild = await client.GetGuildAsync("Gasmask");
    }
````

## Contributions

If you're confident with C#, feel free to help us by scaffolding the remainder of the Wynncraft API. Once done, open a pull request.

## Functionality

- [x] Guilds
- [x] Logging
- [x] Players
- [x] Items
- [x] Professions
- [x] Territories
- [x] Leaderboards
- [x] Lists
- [ ] Advanced configuration

