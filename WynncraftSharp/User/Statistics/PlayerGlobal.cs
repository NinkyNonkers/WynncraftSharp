namespace WynncraftSharp.User.Statistics;

public class PlayerGlobal
{
    public uint ChestsFound { get; internal set; }
    public ulong BlocksWalked { get; internal set; }
    public uint Logins { get; internal set; }
    public uint Deaths { get; internal set; }
    public uint Discoveries { get; internal set; }
    public uint EventsWon { get; internal set; }
    public uint ItemsIdentified { get; internal set; }
    public uint MobsKilled { get; internal set; }
    public PlayerPvP Pvp { get; internal set; }
}