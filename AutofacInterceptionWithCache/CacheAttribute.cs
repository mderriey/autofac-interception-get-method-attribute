using System;

namespace AutofacInterceptionWithCache
{
    [AttributeUsage(AttributeTargets.Method)]
    public class CacheAttribute : Attribute
    {
        public CacheAttribute(int duration)
        {
            Duration = duration;
        }

        public int Duration { get; }
    }
}