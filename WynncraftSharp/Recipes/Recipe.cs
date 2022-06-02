using WynncraftSharp.API.Requests.Latest;
using WynncraftSharp.Common;

namespace WynncraftSharp.Recipes;

public class Recipe : LatestRequestObjectBase, IRecipe
{
    
    
    public Recipe(IWynncraftApiClient client) : base(client, "/recipe/get")
    {
        
    }
    
    public RangeDescriptor<ushort> Level { get; internal set; }
    public string Type { get; internal set; }
    public string Skill { get; internal set; }
    public RecipeMaterial[] Materials { get; internal set; }
    public RangeDescriptor<short> HealthOrDamage { get; internal set; }
    public RangeDescriptor<int> Durability { get; internal set; }
    public string Id { get; internal set; }
}