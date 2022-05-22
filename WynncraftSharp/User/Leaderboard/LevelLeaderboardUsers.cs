namespace WynncraftSharp.User.Leaderboard;

public class LevelLeaderboardUsers : LeaderboardUsers
{
    public LevelLeaderboardUsers(IWynncraftApiClient client) : base(client, "statsLeaderboard&type=player")
    {
    }
}