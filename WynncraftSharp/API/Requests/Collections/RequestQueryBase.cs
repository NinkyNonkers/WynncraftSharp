using Newtonsoft.Json;

namespace WynncraftSharp.API.Requests.Collections;

public abstract class RequestQueryBase<T> : RequestCollectionBase<T>
{
    public RequestQueryBase(IWynncraftApiClient client, string endpoint) : base(client, endpoint, "ignore")
    {
    }

    [JsonProperty("data")]
    public override T[] Collection { get; internal set; }
}