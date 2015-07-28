using DomainEventSample.Domain;
using DomainEventSample.DomainEvent;
using DomainEventSample.DomainEventHandler;
using Ninject;
using Ninject.Modules;

namespace DomainEventSample.DependencyInjection.NinjectDI
{
    public class ServiceModule: NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IDomainEventHandler<PasswordChangedEvent>>().To<PasswordChangedEventHandler>();
            Kernel.Bind<IDomainEventHandler<UserCreatedEvent>>().To<UserCreatedEventHandler>();
            Kernel.Bind<IDomainEventHandler<UserActivatedEvent>>().To<UserActivatedEventHandler>();

            Kernel.Bind<IDomainRepository>().To<DomainRepository>();

            Kernel.Bind<IServiceLocator>().To<NinjectServiceLocator>();
            Kernel.Bind<IDomainEventDispatcher>().To<DomainEventDispatcher>();

            DomainEvents.Dispatcher = Kernel.Get<IDomainEventDispatcher>();
        }
    }
}