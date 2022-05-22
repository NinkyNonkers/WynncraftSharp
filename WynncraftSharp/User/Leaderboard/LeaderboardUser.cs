using WynncraftSharp.Common.Entity;

namespace WynncraftSharp.User.Leaderboard;

public class LeaderboardUser : IUser, ILeaderboardEntry
{
    public string Name { get; internal set; }
    public string UUID { get; internal set; }
    public uint Kills { get; internal set; }
    public ushort Level { get; internal set; }
    public uint XP { get; internal set; }
    public uint MinPlayed { get; internal set; }
    public string Tag { get; internal set; }
    public string Rank { get; internal set; }
    public bool DisplayTag { get; internal set; }
    public bool Veteran { get; internal set; }
    public string GuildTag { get; internal set; }
    public string Guild { get; internal set; }
    public long Num { get; internal set; }
}