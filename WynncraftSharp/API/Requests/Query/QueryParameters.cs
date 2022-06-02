using WynncraftSharp.API.Requests.Query.Pattern;

namespace WynncraftSharp.API.Requests.Query;

//This implementation is genuinely shocking if I do say so myself - definitely going to need documentation. I
//TODO: create Linq-like pattern matching for this. the user requests then may then use complex algorithms to determine their result
public static class QueryParameters
{
    public static RequestParameter[] CreateSimple(SimpleParameterType param, string value)
    {
        List<RequestParameter> parameters = new List<RequestParameter>();

        switch (param)
        {
            case SimpleParameterType.Type:
                parameters.Add(new RequestParameter("", "type"));
                break;
            case SimpleParameterType.Skill:
                parameters.Add(new RequestParameter("", "skill"));
                break;
        }
        
        parameters.Add(new RequestParameter("", value));
        return parameters.ToArray();
    }

    public static RequestParameter[] CreateComplex<T>(PatternMatch<T> match, ComplexParameterType type)
    {
        List<RequestParameter> parameters = new List<RequestParameter>();

        switch (type)
        {
            case ComplexParameterType.Durability:
                parameters.Add(new RequestParameter("", "durability"));
                break;
            case ComplexParameterType.Level:
                parameters.Add(new RequestParameter("", "level"));
                break;
            case ComplexParameterType.HealthOrDamage:
                parameters.Add(new RequestParameter("", "healthOrDamage"));
                break;
            case ComplexParameterType.Duration:
                parameters.Add(new RequestParameter("", "duration"));
                break;
            case ComplexParameterType.BasicDuration:
                parameters.Add(new RequestParameter("", "basicDuration"));
                break;
        }
        
        string matchString;
        switch (match.Type)
        {
            default:
            case PatternMatchType.And:
                matchString = "&";
                break;
            case PatternMatchType.Or:
                matchString = "||";
                break;
        }

        foreach (Pattern<T> pat in match.Patterns)
        {
            switch (pat.Type)
            {
                case PatternType.Minimum:
                    matchString += $"minimum<{pat.Value}>";
                    break;
                case PatternType.Maximum:
                    matchString += $"maximum<{pat.Value}>";
                    break;
            }
        }
        
        parameters.Add(new RequestParameter("", matchString));
        return parameters.ToArray();
    }
    
}