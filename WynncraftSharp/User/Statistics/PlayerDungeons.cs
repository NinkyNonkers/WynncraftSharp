using Newtonsoft.Json;
using WynncraftSharp.Statistics;

namespace WynncraftSharp.User.Statistics;

public class PlayerDungeons
{
    public ushort Completed { get; internal set; }
    [JsonProperty("list")]
    public DungeonCompletions Dungeons { get; internal set; }
}