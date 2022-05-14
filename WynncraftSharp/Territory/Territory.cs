using Newtonsoft.Json;
using WynncraftSharp.Requests.Legacy;

namespace WynncraftSharp.Territory;

public class Territory
{
    [JsonProperty("territory")]
    public string Name { get; internal set; }
    public string Guild { get; internal set; }
    public DateTime Acquired { get; internal set; }
    public string Attacker { get; internal set; }
    public TerritoryLocation Location { get; internal set; }
}