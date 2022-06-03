namespace WynncraftSharp.API.Requests.Legacy;

public interface ILegacyRequest : IRequest
{
    public LegacyRequestInformation Request { get; }
}