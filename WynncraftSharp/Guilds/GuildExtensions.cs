namespace WynncraftSharp.Guilds;

public static class GuildExtensions
{
    public static async Task<Guild> GetGuildAsync(this IWynncraftApiClient client, string name)
    {
        return await client.GetAsync<Guild>(name);
    } 
}