namespace WynncraftSharp.Guilds.Banner;

public class GuildBanner
{
    public string Base { get; internal set; }
    public int Tier { get; internal set; }
    public GuildBannerLayer[] Layers { get; internal set; }
}