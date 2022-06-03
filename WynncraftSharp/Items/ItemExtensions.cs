using WynncraftSharp.API.Requests;

namespace WynncraftSharp.Items;

public static class ItemExtensions
{
    /// <summary>
    /// Searches items from the Wynncraft API by category
    /// </summary>
    /// <param name="client"></param>
    /// <param name="category"></param>
    /// <returns></returns>
    public static async Task<IEnumerable<Item>> SearchItemsByCategoryAsync(this IWynncraftApiClient client, string category)
    {
        return await client.GetWithParametersAsync<ItemCollection>(false, new RequestParameter("category", category));
    }

    /// <summary>
    /// Search items from the Wynncraft API by name
    /// </summary>
    /// <param name="client"></param>
    /// <param name="name"></param>
    /// <returns></returns>
    public static async Task<IEnumerable<Item>> SearchItemsByNameAsync(this IWynncraftApiClient client, string name)
    {
        return await client.GetWithParametersAsync<ItemCollection>(false, new RequestParameter("search", name));
    }
}