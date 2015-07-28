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
            var typeOfHandler = typeof(IDomainEventHandler<>).MakeGenericType(domainEvent.GetType());

            var eventHandlers = serviceLocator.ResolveAll(typeOfHandler);
            
            foreach (var handler in eventHandlers)
            {
                ((dynamic)handler).Handle((dynamic)domainEvent);
            }
        }
    }
}