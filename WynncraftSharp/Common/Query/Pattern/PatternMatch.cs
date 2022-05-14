namespace WynncraftSharp.Common.Query.Pattern;

public class PatternMatch
{
    public static PatternMatch<T> CreateSingle<T>(T value, bool or, PatternType type)
    {
        PatternMatchType mType = PatternMatchType.And;
        if (or)
            mType = PatternMatchType.Or;
        return new PatternMatch<T>(new[] {new Pattern<T>(type, value)}, mType);
    }
}

public class PatternMatch<T> : PatternMatch
{
    public Pattern<T>[] Patterns { get; set; }
    public PatternMatchType Type { get; set; }
    
    public PatternMatch(Pattern<T>[] patterns, PatternMatchType type)
    {
        Patterns = patterns;
        Type = type;
    }
}