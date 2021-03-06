// ReSharper disable UnassignedGetOnlyAutoProperty

using WynncraftSharp.API.Requests.Legacy;
using WynncraftSharp.Common;
using WynncraftSharp.Common.Entity;
using WynncraftSharp.Guilds.Banner;

namespace WynncraftSharp.Guilds;

public class Guild : LegacyRequestObjectBase, IGuild
{
    public string Name { get; internal set; }
    public string Prefix { get; internal set; }
    public ushort XP { get; internal set; }
    public DateTime Created { get; internal set; }
    public string UserFriendlyCreatedTime { get; internal set; }
    public int Territories { get; internal set; }
    public GuildBanner Banner { get; internal set; }
    public GuildMember[] Members { get; internal set; }

#pragma warning disable CS8618
    public Guild(IWynncraftApiClient client) : base(client, "guildStats")
#pragma warning restore CS8618
    {
        
    }
}