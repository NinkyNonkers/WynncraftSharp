namespace WynncraftSharp.Network;

public static class NetworkExtensions
{
    public static async Task<PlayersOnline> GetPlayerCountAsync(this IWynncraftApiClient client)
    {
        return await client.GetAsync<PlayersOnline>();
    }
}