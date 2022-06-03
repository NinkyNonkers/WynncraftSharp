using Newtonsoft.Json;
using WynncraftSharp.API.JSON;
using WynncraftSharp.API.Requests.Legacy;
using WynncraftSharp.API.Versioning;

namespace WynncraftSharp.Guilds;

[JsonCollection]
public class GuildCollection : LegacyRequestCollectionBase<string>
{
    public GuildCollection(IWynncraftApiClient client) : base(client, "guildList", "guilds")
    {
        ExpectedApiVersion = ApiVersion.Legacy;
    }
    
    [JsonProperty("guilds")]
    public override string[] Collection { get; internal set; }
}