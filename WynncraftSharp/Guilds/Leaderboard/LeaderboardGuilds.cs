using Newtonsoft.Json;
using WynncraftSharp.API.Requests.Legacy;
using WynncraftSharp.API.Versioning;

namespace WynncraftSharp.Guilds.Leaderboard;

public class LeaderboardGuilds : LegacyRequestCollectionBase<LeaderboardGuild>
{
    public LeaderboardGuilds(IWynncraftApiClient client) : base(client, new VersionedEndpoint {Legacy = "statsLeaderboard&type=guild", WebApi = "leaderboards/guild"}, "ignore")
    {
        IsCrossVersion = true;
    }

    [JsonProperty("data")]
    public override LeaderboardGuild[] Collection { get; internal set; }
}