namespace WynncraftSharp.Territory;

public static class TerritoryExtensions
{
    public static async Task<IEnumerable<Territory>> GetTerritories(this IWynncraftApiClient client)
    {
        return await client.GetAsync<TerritoryCollection>();
    }
}