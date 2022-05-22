using WynncraftSharp.Common.Entity;
using WynncraftSharp.Guilds.Banner;

namespace WynncraftSharp.Guilds.Leaderboard;

public class LeaderboardGuild : IGuild, ILeaderboardEntry
{
    public string Name { get; internal set; }
    public string Prefix { get; internal set; }
    public uint XP { get; internal set; }
    public ushort Level { get; internal set; }
    public DateTime Created { get; internal set; }
    public GuildBanner Banner { get; internal set; }
    public ushort Territories { get; internal set; }
    public ushort Members { get; internal set; }
    public long Num { get; internal set; }
}