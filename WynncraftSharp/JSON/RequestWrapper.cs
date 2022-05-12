using WynncraftSharp.Requests;

namespace WynncraftSharp.JSON;

public class RequestWrapper<TTarget> where TTarget : class, IRequest
{
    public TTarget Request { get; }
    
    //parameterless constructor for deserialization
#pragma warning disable CS8618
    public RequestWrapper()
#pragma warning restore CS8618
    {
        
    }

    public RequestWrapper(TTarget obj)
    {
        Request = obj;
    }

}