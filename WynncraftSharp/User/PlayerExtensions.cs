using WynncraftSharp.Common;
using WynncraftSharp.Common.Entity;

namespace WynncraftSharp.User;

public static class PlayerExtensions
{
    
    /// <summary>
    /// Gets a Player object from the Wynncraft API
    /// </summary>
    /// <param name="client"></param>
    /// <param name="identifier">Username or UUID</param>
    /// <returns></returns>
    public static async Task<Player> GetPlayerAsync(this IWynncraftApiClient client, string identifier)
    {
        return await client.GetAsync<Player>(identifier + "/stats");
    }
    
    /// <summary>
    /// Gets a Player object from the Wynncraft API
    /// </summary>
    /// <param name="client"></param>
    /// <param name="user"></param>
    /// <returns></returns>
    
    public static async Task<Player> GetPlayerAsync(this IWynncraftApiClient client, IUser user)
    {
        return await GetPlayerAsync(client, user.UUID);
    }
}