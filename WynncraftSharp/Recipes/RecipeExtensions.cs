using WynncraftSharp.Requests;

namespace WynncraftSharp.Recipes;

//TODO: add documentation on how to use pattern matching here
public static class RecipeExtensions
{
    public static async Task<Recipe> GetRecipeAsync(this IWynncraftApiClient client, string name)
    {
        return await client.GetAsync<Recipe>(name);
    }

    public static async Task<RecipeSearch> SearchRecipeAsync(this IWynncraftApiClient client, RequestParameter[] param)
    {
        return await client.GetWithParametersAsync<RecipeSearch>(true, param);
    }
}