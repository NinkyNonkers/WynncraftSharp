using WynncraftSharp.Requests;
using WynncraftSharp.Requests.Versions;

namespace WynncraftSharp.Network;

public class PlayersOnline : RequestObjectBase, ILegacyObject
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

    public Request Request { get; internal set; }
}