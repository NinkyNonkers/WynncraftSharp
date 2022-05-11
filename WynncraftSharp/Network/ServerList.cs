using WynncraftSharp.Requests;
using WynncraftSharp.Requests.Versions;

namespace WynncraftSharp.Network;

//TODO: implement dynamic object to handle varying server availability
public class ServerList : RequestObjectBase, ILegacyObject
{
    
    public ServerList(IWynncraftApiClient client) : base(client, "onlinePlayers")
    {
        throw new NotImplementedException();
    }
    
    
    public Request Request { get; }
}