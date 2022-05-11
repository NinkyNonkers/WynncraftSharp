using System.Collections;
using Newtonsoft.Json;
using WynncraftSharp.Requests;
using WynncraftSharp.Requests.Collections;
using WynncraftSharp.Requests.Legacy;

namespace WynncraftSharp.Guilds;

public class GuildCollection : ILegacyRequest, IRequestCollection<Guild>
{
    [JsonProperty("guilds")]
#pragma warning disable CS8618
    private Guild[] _guilds;
#pragma warning restore CS8618

    public IEnumerator<Guild> GetEnumerator()
    {
        return _guilds.ToList().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public GuildCollection(IWynncraftApiClient client)
    {
        _client = client;
    }
    
    [JsonIgnore]
    private readonly IWynncraftApiClient _client;

    public LegacyRequestInformation Request { get; internal set; }

    public string Endpoint { get; } = "guildList";
    public string DataName { get; } = "guilds";
}