namespace WynncraftSharp.User;

public static class PlayerExtensions
{
    public static async Task<Player> GetPlayerAsync(this IWynncraftApiClient client, string identifier)
    {
        return await client.GetAsync<Player>(identifier + "/stats");
    }
}