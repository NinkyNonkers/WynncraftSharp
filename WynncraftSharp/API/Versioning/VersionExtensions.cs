namespace WynncraftSharp.API.Versioning;

public static class VersionExtensions
{
    public static bool IsLatest(this ApiVersion version)
    {
        return version is ApiVersion.V3 or ApiVersion.V2;
    }
    
}