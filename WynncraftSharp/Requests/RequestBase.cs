namespace WynncraftSharp.Requests;

public abstract class RequestBase : IRequest
{
    protected RequestBase(IWynncraftApiClient client)
    {
        Client = client;
    }

    public abstract string Endpoint { get; }
    public ApiVersion ExpectedApiVersion { get; protected set; }
    protected IWynncraftApiClient Client { get; }

}