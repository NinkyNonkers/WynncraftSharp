namespace WynncraftSharp.API.Versioning;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class SpecificVersionAttribute
{
    public ApiVersion Version { get; }
    
    public SpecificVersionAttribute(ApiVersion version)
    {
        Version = version;
    }
}
