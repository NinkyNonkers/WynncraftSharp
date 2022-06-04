using WynncraftSharp.API.Requests.Legacy;
using WynncraftSharp.API.Versioning;

namespace WynncraftSharp.User.Leaderboard;

public abstract class LeaderboardUsers : LegacyRequestCollectionBase<LeaderboardUser>
{
    protected LeaderboardUsers(IWynncraftApiClient client, VersionedEndpoint endpoint) : base(client, endpoint, "ignore")
    {
    }
    
    protected LeaderboardUsers(IWynncraftApiClient client, string endpoint) : base(client, endpoint, "ignore")
    {
    }

    public override LeaderboardUser[] Collection { get; internal set; }
}