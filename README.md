# WynncraftSharp

Wynncraft API wrapped with delightful modern .NET practices, whilst remaining extremely user friendly.

## Getting started

WynncraftSharp uses .NET Standard 2.1, meaning it is usable on almost all branches of the .NET system, as long as there is a http implementation in the runtime used.

[Download via NuGet](https://github.com/openmod/OpenMod/actions?query=workflow%3AOpenMod.UnityEngine.Redist)


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

## Version 3 Support
Due to the lack of documentation available on the Wynncraft API website and the fact that it is still in development, the version is barely implemented and will be so until it is fully released. Currently, work is being done on redesigning the wrapper in order to support these changes as well as the original API.
