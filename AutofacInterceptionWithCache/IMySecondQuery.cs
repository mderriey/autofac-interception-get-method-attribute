using System;

namespace AutofacInterceptionWithCache
{
    public interface IMySecondQuery
    {
        [Cache(1000)]
        string GetSecondName();
    }
}