using System;

namespace AutofacInterceptionWithCache
{
    public interface IMyQuery
    {
        [Cache(60000)]
        string GetName();
    }
}