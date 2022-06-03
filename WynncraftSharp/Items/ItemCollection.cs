using Newtonsoft.Json;
using WynncraftSharp.API.JSON;
using WynncraftSharp.API.Requests.Legacy;

namespace WynncraftSharp.Items;


[JsonCollection]
public class ItemCollection : LegacyRequestCollectionBase<Item>
{
    public ItemCollection(IWynncraftApiClient client) : base(client, "itemDB", "items")
    {
    }

    [JsonProperty("items")]
    public override Item[] Collection { get; internal set; }
}