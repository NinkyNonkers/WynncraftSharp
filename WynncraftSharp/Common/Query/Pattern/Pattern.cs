namespace WynncraftSharp.Common.Query.Pattern;

public class Pattern<T>
{
    public PatternType Type { get; set; }
    public T Value { get; set; }
    
    public Pattern(PatternType type, T value)
    {
        Type = type;
        Value = value;
    }
}