using WynncraftSharp.User.Level;
using WynncraftSharp.User.Network;

namespace WynncraftSharp.User.Class;

public class PlayerClass
{
    public string Name { get; internal set; }
    public int Level { get; internal set; }
    public PlayerDungeons Dungeons { get; internal set; }
    public PlayerQuests Quests { get; internal set; }
    public PlayerPvP Pvp { get; internal set; }
    
    public uint ChestsFound { get; internal set; }
    public ulong BlocksWalked { get; internal set; }
    public uint Logins { get; internal set; }
    public uint Deaths { get; internal set; }
    public uint Playtimes { get; internal set; }
    
    public PlayerGamemode Gamemode { get; internal set; }
    public PlayerSkills Skills { get; internal set; }
    
    public uint Discoveries { get; internal set; }
    public uint EventsWon { get; internal set; }
    public uint ItemsIdentified { get; internal set; }
    public uint MobsKilled { get; internal set; }
    
    //TODO: implement this properly
    //public bool PreEconomy { get; internal set; }
}