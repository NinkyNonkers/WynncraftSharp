using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace WynncraftSharp.JSON;

public class RequestObjectResolver : DefaultContractResolver
{
    protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization ser)
    {
        JsonProperty res = base.CreateProperty(member, ser);
        res.Writable = true;
        return res;
    }
}