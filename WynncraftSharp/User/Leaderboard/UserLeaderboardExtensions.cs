using WynncraftSharp.API.Requests;

namespace WynncraftSharp.User.Leaderboard;

public static class UserLeaderboardExtensions
{
    public static async Task<IEnumerable<LeaderboardUser>> GetUserLeaderboardAsync(this IWynncraftApiClient client, UserLeaderboard lb, int timeframe = -1)
    {
        switch (lb)
        {
            default:
            case UserLeaderboard.Level:
                if (timeframe == -1) 
                    return await client.GetWithParametersAsync<LevelLeaderboardUsers>(false, new RequestParameter("timeframe", "alltime"));
                return await client.GetWithParametersAsync<LevelLeaderboardUsers>(false, new RequestParameter("timeframe", timeframe.ToString()));
            case UserLeaderboard.PvP:
                if (timeframe == -1) 
                    return await client.GetWithParametersAsync<PvPLeaderboardUsers>(false, new RequestParameter("timeframe", "alltime"));
                return await client.GetWithParametersAsync<PvPLeaderboardUsers>(false, new RequestParameter("timeframe", timeframe.ToString()));
        }
    }
}