using Newtonsoft.Json;
using WynncraftSharp.Items;

namespace WynncraftSharp.Recipes;

public class RecipeMaterial : IItem
{
    [JsonProperty("item")]
    public string Name { get; internal set; }
    public ushort Amount { get; internal set; }
}