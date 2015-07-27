using System;
using System.Collections.Generic;

namespace DomainEventSample
{
    public interface IServiceLocator
    {
        object Resolve(Type type);
        IEnumerable<object> ResolveAll(Type type);
        IEnumerable<T> ResolveAll<T>();
    }
}