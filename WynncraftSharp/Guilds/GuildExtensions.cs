using WynncraftSharp.Common;
using WynncraftSharp.Common.Entity;

namespace WynncraftSharp.Guilds;

public static class GuildExtensions
{
    /// <summary>
    /// Gets a guild object from the Wynncraft API
    /// </summary>
    /// <param name="client"></param>
    /// <param name="name"></param>
    /// <returns></returns>
    public static async Task<Guild> GetGuildAsync(this IWynncraftApiClient client, string name)
    {
        return await client.GetAsync<Guild>(name);
    } 
    
    public static async Task<Guild> GetGuildAsync(this IWynncraftApiClient client, IGuild guild)
    {
        return await GetGuildAsync(client, guild.Name);
    }

    /// <summary>
    /// Lists all guild from the Wynncraft API
    /// </summary>
    /// <param name="client"></param>
    /// <returns></returns>
    public static async Task<IEnumerable<string>> GetGuildsAsync(this IWynncraftApiClient client)
    {
        return await client.GetAsync<GuildCollection>("", false);
    }
    
}