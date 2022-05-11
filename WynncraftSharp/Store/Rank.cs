using Newtonsoft.Json;

namespace WynncraftSharp.Store;

public class Rank : IEquatable<string>
{
    [JsonProperty("value")]
    public string Name { get; internal set; }
    public bool Display { get; internal set; }
    
    internal Rank(string name)
    {
        Name = name;
    }

    //for JSON
    public Rank()
    {
        
    }
    
    public static implicit operator string(Rank value)
    {
        return value.Name;
    }
    
    private bool Equals(Rank other)
    {
        return other.Name == Name;
    }

    public bool Equals(string? other)
    {
        return Name == other;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((Rank) obj);
    }

    public override int GetHashCode()
    {
        // ReSharper disable once NonReadonlyMemberInGetHashCode
        return Name.GetHashCode();
    }
}