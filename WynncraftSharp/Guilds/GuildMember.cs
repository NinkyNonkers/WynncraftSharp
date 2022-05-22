using Newtonsoft.Json;
using WynncraftSharp.Common;
using WynncraftSharp.Common.Entity;
using WynncraftSharp.User;

namespace WynncraftSharp.Guilds;

public class GuildMember : IUser
{
    public string Name { get; internal set; }
    public string UUID { get; internal set; }
    [JsonProperty("Rank")]
    public string GuildRank { get; internal set; }
    public ulong Contributed { get; internal set; }
    public DateTime Joined { get; internal set; }
    public string JoinedFriendly { get; internal set; }
}