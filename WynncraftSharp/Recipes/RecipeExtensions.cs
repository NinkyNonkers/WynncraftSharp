using WynncraftSharp.API.Requests;

namespace WynncraftSharp.Recipes;

//TODO: add documentation on how to use pattern matching here
public static class RecipeExtensions
{
    /// <summary>
    /// Gets a recipe object from the Wynncraft API
    /// </summary>
    /// <param name="client"></param>
    /// <param name="name"></param>
    /// <returns></returns>
    public static async Task<Recipe> GetRecipeAsync(this IWynncraftApiClient client, string name)
    {
        return await client.GetAsync<Recipe>(name);
    }

    /// <summary>
    /// Gets all recipes from the Wynncraft APi
    /// </summary>
    /// <param name="client"></param>
    /// <returns></returns>
    public static async Task<IEnumerable<string>> GetRecipesAsync(this IWynncraftApiClient client)
    {
        return await client.GetAsync<RecipeCollection>();
    }

    /// <summary>
    /// Search recipes on the Wynncraft API
    /// </summary>
    /// <param name="client"></param>
    /// <param name="param">Queries for the search, use QueryParameters.Create to generate</param>
    /// <returns></returns>
    public static async Task<RecipeSearch> SearchRecipeAsync(this IWynncraftApiClient client, RequestParameter[] param)
    {
        return await client.GetWithParametersAsync<RecipeSearch>(true, param);
    }
}