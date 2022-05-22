namespace WynncraftSharp.User.Leaderboard;

public class PvPLeaderboardUsers : LeaderboardUsers
{
    public PvPLeaderboardUsers(IWynncraftApiClient client) : base(client, "statsLeaderboard&type=pvp")
    {
    }
}