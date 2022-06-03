namespace WynncraftSharp.Territory;

public static class TerritoryExtensions
{
    /// <summary>
    /// Gets all existing territories from the Wynncraft API
    /// </summary>
    /// <param name="client"></param>
    /// <returns></returns>
    public static async Task<IEnumerable<Territory>> GetTerritoriesAsync(this IWynncraftApiClient client)
    {
        return await client.GetAsync<TerritoryCollection>();
    }
}