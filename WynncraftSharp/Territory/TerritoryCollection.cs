using WynncraftSharp.API.Requests.Legacy;

namespace WynncraftSharp.Territory;

public class TerritoryCollection : LegacyRequestCollectionBase<Territory>
{
    public TerritoryCollection(IWynncraftApiClient client) : base(client, "territoryList", "territories")
    {
    }

    public override Territory[] Collection { get; internal set; }
}