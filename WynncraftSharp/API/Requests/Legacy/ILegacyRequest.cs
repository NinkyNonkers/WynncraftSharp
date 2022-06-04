namespace WynncraftSharp.API.Requests.Legacy;

/// <summary>
/// Request in the "Legacy" version
/// </summary>
public interface ILegacyRequest : IRequest
{
    public LegacyRequestInformation Request { get; }
}