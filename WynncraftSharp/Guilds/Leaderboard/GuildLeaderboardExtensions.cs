using WynncraftSharp.Requests;

namespace WynncraftSharp.Guilds.Leaderboard;

public static class GuildLeaderboardExtensions
{
    public static async Task<IEnumerable<LeaderboardGuild>> GetGuildLeaderboardAsync(this IWynncraftApiClient client, int timeframe = -1)
    {
        if (timeframe == -1) 
            return await client.GetWithParametersAsync<LeaderboardGuilds>(false, new RequestParameter("timeframe", "alltime"));
        return await client.GetWithParametersAsync<LeaderboardGuilds>(false, new RequestParameter("timeframe", timeframe.ToString()));
    }
}