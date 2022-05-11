using WynncraftSharp.Requests;

namespace WynncraftSharp.JSON;

public class RequestObjectWrapper<TTarget> where TTarget : class, IRequestObject
{
    public TTarget RequestObject { get; }

    
    //parameterless constructor for deserialization
#pragma warning disable CS8618
    public RequestObjectWrapper()
#pragma warning restore CS8618
    {
        
    }

    public RequestObjectWrapper(TTarget obj)
    {
        RequestObject = obj;
    }

}