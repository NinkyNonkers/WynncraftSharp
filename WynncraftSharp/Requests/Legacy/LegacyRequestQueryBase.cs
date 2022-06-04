using WynncraftSharp.Requests.Collections.Query;
using WynncraftSharp.Requests.Query;

namespace WynncraftSharp.Requests.Legacy;

public class LegacyRequestQueryBase<T> : RequestQueryBase<T>
{
    public LegacyRequestQueryBase(IWynncraftApiClient client, string endpoint) : base(client, endpoint)
    {
    }

    public LegacyRequestInformation Request { get; internal set; }
}