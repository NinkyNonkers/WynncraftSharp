using Newtonsoft.Json;
using WynncraftSharp.Statistics;

namespace WynncraftSharp.User.Class;

public class PlayerDungeons
{
    public ushort Completed { get; internal set; }
    
    [JsonProperty("list")]
    public DungeonCompletion[] Dungeons { get; internal set; }
}