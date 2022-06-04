using WynncraftSharp.API.Requests.Collections;

namespace WynncraftSharp.API.Requests.Legacy;

public class LegacyRequestQueryBase<T> : RequestQueryBase<T>
{
    public LegacyRequestQueryBase(IWynncraftApiClient client, string endpoint) : base(client, endpoint)
    {
    }

    public LegacyRequestInformation Request { get; internal set; }
}