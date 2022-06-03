using Newtonsoft.Json;
using WynncraftSharp.API.Requests.Latest;

namespace WynncraftSharp.Recipes;

//TODO: reduce hackiness by improving framework for this method
public class RecipeSearch : LatestRequestObjectBase
{
    
    public RecipeSearch(IWynncraftApiClient client) : base(client, "/recipe/search", "exempt")
    {
    }
    
    [JsonProperty("data")]
    public Recipe[] Recipes { get; internal set; }
}