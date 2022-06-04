using WynncraftSharp.API.Versioning;

namespace WynncraftSharp.User.Leaderboard;

public class PvPLeaderboardUsers : LeaderboardUsers
{
    public PvPLeaderboardUsers(IWynncraftApiClient client)
        : base(client, new VersionedEndpoint {Legacy = "statsLeaderboard&type=pvp", WebApi = "leaderboards/pvp"})
    {
        IsCrossVersion = true;
    }
}