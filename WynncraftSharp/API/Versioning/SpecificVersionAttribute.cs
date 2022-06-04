namespace WynncraftSharp.API.Versioning;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Class | AttributeTargets.Enum)]
public class SpecificVersionAttribute : Attribute
{
    public ApiVersion Version { get; }
    
    public SpecificVersionAttribute(ApiVersion version)
    {
        Version = version;
    }
}
