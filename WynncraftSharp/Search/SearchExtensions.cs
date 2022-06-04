using WynncraftSharp.API.Requests;

namespace WynncraftSharp.Search;

public static class SearchExtensions
{
    /// <summary>
    /// Searches clients and guilds from the Wynncraft API
    /// </summary>
    /// <param name="client"></param>
    /// <param name="name"></param>
    /// <returns></returns>
    public static async Task<StatsSearch> SearchAsync(this IWynncraftApiClient client, string name)
    {
        return await client.GetAsync<StatsSearch>(true, new RequestParameter("search", name));
    }
}