using WynncraftSharp.Common;
using WynncraftSharp.Common.Entity;
using WynncraftSharp.Guilds;

namespace WynncraftSharp.User.Statistics;

public class PlayerGuild : IGuild
{
    public string Name { get; internal set; }
    public string Rank { get; internal set; }
}