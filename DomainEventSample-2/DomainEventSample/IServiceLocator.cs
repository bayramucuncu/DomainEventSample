using System;
using System.Collections.Generic;

namespace DomainEventSample
{
    public interface IServiceLocator
    {
        object Resolve(Type type);
        IEnumerable<T> ResolveAll<T>();
        IEnumerable<object> ResolveAll(Type type);
    }
}