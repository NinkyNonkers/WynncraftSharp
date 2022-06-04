using WynncraftSharp.API.Versioning;

namespace WynncraftSharp;

public class ClientConfiguration
{
    public ApiVersion VersionPreference { get; set; } = ApiVersion.V2;
    public bool AutomaticallyGetExtensions { get; set; } = true;
}