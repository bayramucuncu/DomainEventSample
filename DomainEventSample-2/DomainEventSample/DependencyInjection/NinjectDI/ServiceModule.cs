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
            Kernel.Bind<IDomainEventHandler<PasswordChangedEvent>>().To<UserAccountDenormalizer>();
            Kernel.Bind<IDomainEventHandler<UserCreatedEvent>>().To<UserAccountDenormalizer>();
            Kernel.Bind<IDomainEventHandler<UserActivatedEvent>>().To<UserAccountDenormalizer>();

            Kernel.Bind<IDomainRepository>().To<DomainRepository>();

            Kernel.Bind<IServiceLocator>().To<NinjectServiceLocator>();
            Kernel.Bind<IDomainEventDispatcher>().To<DomainEventDispatcher>();

            DomainEvents.Dispatcher = Kernel.Get<IDomainEventDispatcher>();
        }
    }
}