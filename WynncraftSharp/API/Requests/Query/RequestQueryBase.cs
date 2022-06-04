using Newtonsoft.Json;
using WynncraftSharp.API.Requests.Collections;

namespace WynncraftSharp.API.Requests.Query;

public abstract class RequestQueryBase<T> : RequestCollectionBase<T>
{
    public RequestQueryBase(IWynncraftApiClient client, string endpoint) : base(client, endpoint, "ignore")
    {
    }

    [JsonProperty("data")]
    public override T[] Collection { get; internal set; }
}