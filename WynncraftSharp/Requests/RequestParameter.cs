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

    public string ToParameter(bool first)
    {
        char punctuation = '&';
        if (first)
            punctuation = '?';
        return punctuation + $"{PropertyName}={Value}";
    }
}