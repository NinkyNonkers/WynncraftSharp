using Newtonsoft.Json;
using WynncraftSharp.JSON;
using WynncraftSharp.Requests;
using WynncraftSharp.Requests.Legacy;

namespace WynncraftSharp.Guilds;

[JsonCollection]
public class GuildCollection : LegacyRequestCollectionBase<string>
{
    public GuildCollection(IWynncraftApiClient client) : base("guildList", "guilds")
    {
        ExpectedApiVersion = ApiVersion.Legacy;
    }
    
    [JsonProperty("guilds")]
    public override string[] Collection { get; internal set; }
}