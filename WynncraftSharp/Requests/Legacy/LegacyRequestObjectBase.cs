namespace WynncraftSharp.Requests.Legacy;

public abstract class LegacyRequestObjectBase : RequestObjectBase, ILegacyObject
{
    public Request Request { get; internal set; }

    protected LegacyRequestObjectBase(IWynncraftApiClient client, string endpoint, string dataObjectName) : base(client, endpoint, dataObjectName)
    {
        ExpectedApiVersion = ApiVersion.Legacy;
    }

    protected LegacyRequestObjectBase(IWynncraftApiClient client, string endpoint) : base(client, endpoint)
    {
        ExpectedApiVersion = ApiVersion.Legacy;
    }
}