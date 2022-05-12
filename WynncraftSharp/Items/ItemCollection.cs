using Newtonsoft.Json;
using WynncraftSharp.Requests.Legacy;

namespace WynncraftSharp.Items;

public class ItemCollection : LegacyRequestCollectionBase<Item>
{
    public ItemCollection(IWynncraftApiClient client) : base(client, "itemDB", "items")
    {
    }

    [JsonProperty("items")]
    public override Item[] Collection { get; internal set; }
}