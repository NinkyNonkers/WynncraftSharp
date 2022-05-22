using WynncraftSharp.Requests.Latest;

namespace WynncraftSharp.Recipes;

public class RecipeCollection : LatestRequestCollectionBase<string>
{
    public RecipeCollection(IWynncraftApiClient client) : base(client, "/recipe/list", "data")
    {
        
    }

    public override string[] Collection { get; internal set; }
}