using WynncraftSharp.Requests.Legacy;

namespace WynncraftSharp.Network;

public class PlayersOnline : LegacyRequestObjectBase
{
    
    public static implicit operator int(PlayersOnline value)
    {
        return value.PlayerCount;
    }
    
    public PlayersOnline(IWynncraftApiClient client) : base(client, "onlinePlayersSum")
    {
    }
    
    // ReSharper disable once MemberCanBePrivate.Global
    public ushort PlayerCount { get; internal set; }

}