using Newtonsoft.Json;
using WynncraftSharp.Common.Entity;
using WynncraftSharp.Requests.Latest;
using WynncraftSharp.User.Class;
using WynncraftSharp.User.Network;

namespace WynncraftSharp.User;

public class Player : LatestRequestObjectBase, IUser
{
    public Player(IWynncraftApiClient client) : base(client, "player")
    {
    }

    [JsonProperty("Username")]
    public string Name { get; internal set; }
    
    public string UUID { get; internal set; }
    
    public string Rank { get; internal set; }

    public PlayerMeta Meta { get; internal set; }
    public PlayerClass[] Classes { get; internal set; }
    public PlayerGuild Guild { get; internal set; }
    public PlayerGlobal Global { get; internal set; }

}