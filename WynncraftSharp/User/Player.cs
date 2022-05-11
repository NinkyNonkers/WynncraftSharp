using WynncraftSharp.Requests.Latest;
using WynncraftSharp.User.Statistics;

namespace WynncraftSharp.User;

public class Player : LatestRequestObjectBase, IUser
{
    public Player(IWynncraftApiClient client) : base(client, "player")
    {
    }

    public string Name
    {
        get => Username;
    }
    
    public string Username { get; internal set; }
    
    public string UUID { get; internal set; }
    
    public string Rank { get; internal set; }

    public PlayerMeta Meta { get; internal set; }
    public PlayerClass[] Classes { get; internal set; }
    public PlayerGuild Guild { get; internal set; }
    public PlayerGlobal Global { get; internal set; }

}