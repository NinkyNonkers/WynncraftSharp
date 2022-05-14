using WynncraftSharp.Common;

namespace WynncraftSharp.Recipes;

public interface IRecipe
{
    public RangeDescriptor<ushort> Level { get; }
    public string Type { get; }
    public string Skill { get; }
    public RecipeMaterial[] Materials { get; }
    public RangeDescriptor<short> HealthOrDamage { get; }
    public RangeDescriptor<int> Durability { get; }
    public string Id { get; }
}