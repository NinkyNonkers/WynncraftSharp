namespace WynncraftSharp.Guilds;

public static class GuildExtensions
{
    public static async Task<Guild> GetGuildAsync(this IWynncraftApiClient client, string name)
    {
        return await client.GetAsync<Guild>(name);
    } 
    
    public static async Task<Guild> GetGuildAsync(this IWynncraftApiClient client, IGuild guild)
    {
        return await GetGuildAsync(client, guild.Name);
    }

    public static async Task<GuildCollection> GetGuildsAsync(this IWynncraftApiClient client)
    {
        return await client.GetAsync<GuildCollection>("", false);
    }
    
}