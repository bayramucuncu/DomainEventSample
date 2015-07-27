using DomainEventSample.DomainEvent;

namespace DomainEventSample.DomainEventHandler
{
    public class DomainEventDispatcher : IDomainEventDispatcher
    {
        private readonly IServiceLocator serviceLocator;

        public DomainEventDispatcher(IServiceLocator serviceLocator)
        {
            this.serviceLocator = serviceLocator;
        }

        public void Dispatch<TDomainEvent>(TDomainEvent domainEvent) where TDomainEvent : IDomainEvent
        {
            foreach (var handler in serviceLocator.ResolveAll<IDomainEventHandler<TDomainEvent>>())
            {
                handler.Handle(domainEvent);
            }
        }
    }
}