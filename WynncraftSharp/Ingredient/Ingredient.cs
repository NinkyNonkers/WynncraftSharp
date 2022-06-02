using System.Dynamic;
using WynncraftSharp.API.Requests.Latest;
using WynncraftSharp.Common.Item;

namespace WynncraftSharp.Ingredient;

public class Ingredient : LatestRequestObjectBase, IItem
{
    public Ingredient(IWynncraftApiClient client) : base(client, "/ingredient/get")
    {
    }
    
    public string Name { get; internal set; }
    public string DisplayName { get; internal set; }
    public int Tier { get; internal set; }
    public ushort Level { get; internal set; }
    public string[] Skills { get; internal set; }
    public ItemSpecification Sprite { get; internal set; }
    //TODO: figure out a better way to do this, RangeDescriptor already exists
    public ExpandoObject Identifications { get; internal set; }
    public ConsumableSpecification ConsumableOnlyIDs { get; internal set; }
    public Position IngredientPositionModifiers { get; internal set; }
}