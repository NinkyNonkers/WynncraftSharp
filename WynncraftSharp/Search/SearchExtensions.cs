using WynncraftSharp.Requests;

namespace WynncraftSharp.Search;

public static class SearchExtensions
{
    public static async Task<StatsSearch> SearchAsync(this IWynncraftApiClient client, string name)
    {
        return await client.GetWithParametersAsync<StatsSearch>(true, new RequestParameter("search", name));
    }
}