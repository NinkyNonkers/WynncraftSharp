using WynncraftSharp.Requests.Legacy;

namespace WynncraftSharp.Network;

//TODO: implement dynamic object to handle varying server availability
public class ServerList : LegacyRequestObjectBase
{
    public ServerList(IWynncraftApiClient client) : base(client, "onlinePlayers")
    {
        
    }
    
    public dynamic Servers { get; }
    
    public LegacyRequestInformation Request { get; }
}