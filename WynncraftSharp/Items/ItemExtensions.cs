using WynncraftSharp.Requests;

namespace WynncraftSharp.Items;

public static class ItemExtensions
{
    public static async Task<IEnumerable<Item>> SearchItemsByCategoryAsync(this IWynncraftApiClient client, string category)
    {
        return await client.GetWithParametersAsync<ItemCollection>(false, new RequestParameter("category", category));
    }

    public static async Task<IEnumerable<Item>> SearchItemsByNameAsync(this IWynncraftApiClient client, string name)
    {
        return await client.GetWithParametersAsync<ItemCollection>(false, new RequestParameter("search", name));
    }
}