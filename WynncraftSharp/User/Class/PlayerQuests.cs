using Newtonsoft.Json;

namespace WynncraftSharp.User.Class;

public class PlayerQuests
{
    public ushort Completed { get; internal set; }
    [JsonProperty("list")]
    public string[] Names { get; internal set; }
}