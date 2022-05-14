namespace WynncraftSharp.Requests;

public class RequestParameter
{
    public string PropertyName { get; set; }
    public string Value { get; set; }

    public RequestParameter(string propertyName, string value)
    {
        PropertyName = propertyName;
        Value = value;
    }

    public string ToParameter(ApiVersion version, bool first)
    {
        switch (version)
        {
            case ApiVersion.Legacy:
                char punctuation = '&';
                if (first)
                    punctuation = '?';
                return punctuation + $"{PropertyName}={Value}";
            default:
            case ApiVersion.V2:
                return "/" + Value;
        }
    }
}