using Newtonsoft.Json;
using WynncraftSharp.API.Requests.Legacy;

namespace WynncraftSharp.Guilds.Leaderboard;

public class LeaderboardGuilds : LegacyRequestCollectionBase<LeaderboardGuild>
{
    public LeaderboardGuilds(IWynncraftApiClient client) : base(client, "statsLeaderboard&type=guild", "ignore")
    {
    }

    [JsonProperty("data")]
    public override LeaderboardGuild[] Collection { get; internal set; }
}