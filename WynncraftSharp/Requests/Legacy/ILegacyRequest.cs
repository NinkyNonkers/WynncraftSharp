namespace WynncraftSharp.Requests.Legacy;

public interface ILegacyRequest : IRequest
{
    public LegacyRequestInformation Request { get; }
}