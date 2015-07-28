using System;
using System.Collections.Generic;
using Ninject;

namespace DomainEventSample.DependencyInjection.NinjectDI
{
    public class NinjectServiceLocator : IServiceLocator
    {
        private readonly IKernel kernel;

        public NinjectServiceLocator()
            : this(new StandardKernel())
        {
        }

        public NinjectServiceLocator(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public object Resolve(Type type)
        {
            return kernel.Get(type);
        }

        public IEnumerable<object> ResolveAll(Type type)
        {
            return kernel.GetAll(type);
        }

        public IEnumerable<T> ResolveAll<T>() 
        {
            return kernel.GetAll<T>();
        }

        
    }
}