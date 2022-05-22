using WynncraftSharp.Common.Entity;

namespace WynncraftSharp.User.Network;

public class PlayerGuild : IGuild
{
    public string Name { get; internal set; }
    public string Rank { get; internal set; }
}