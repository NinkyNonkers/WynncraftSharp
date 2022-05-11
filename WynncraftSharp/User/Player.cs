using WynncraftSharp.Requests;
using WynncraftSharp.Requests.Versions;
using WynncraftSharp.Store;
using WynncraftSharp.User.Statistics;

namespace WynncraftSharp.User;

public class Player : RequestObjectBase, IUser, ILatestObject
{
    public Player(IWynncraftApiClient client) : base(client, "player")
    {
    }


    #region Request

    public string Kind { get; internal set; }
    public int Code { get; internal set; }
    public string Message { get; internal set; }
    public ulong Timestamp { get; internal set; }
    public string Version { get; internal set; }

    #endregion
    
    
    
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