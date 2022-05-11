using WynncraftSharp.Requests.Legacy;

namespace WynncraftSharp.Search;

public class StatsSearch : LegacyRequestObjectBase
{

    public string[] Guilds { get; internal set; }
    public string[] Players { get; internal set; }

    public StatsSearch(IWynncraftApiClient client) : base(client, "statsSearch")
    {
    }
}