﻿using System.Collections;
using WynncraftSharp.Requests.Objects;

namespace WynncraftSharp.Requests.Collections;

public abstract class RequestCollectionBase<T> : IRequestCollection<T>
{
    // ReSharper disable once MemberCanBePrivate.Global
    public abstract T[] Collection { get; internal set; }
    
    public IEnumerator<T> GetEnumerator()
    {
        return Collection.ToList().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
    protected RequestCollectionBase(string endpoint, string dataObjectName)
    {
        Endpoint = endpoint;
        DataName = dataObjectName;
    }

    public string Endpoint { get; }
    public ApiVersion ExpectedApiVersion { get; protected set; }
    public string DataName { get; }
}