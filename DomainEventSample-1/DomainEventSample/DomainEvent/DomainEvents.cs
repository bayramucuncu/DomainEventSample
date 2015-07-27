using DomainEventSample.DomainEventHandler;

namespace DomainEventSample.DomainEvent
{
    public static class DomainEvents
    {
        public static IDomainEventDispatcher Dispatcher { get; set; }

        public static void Raise<TDomainEvent>(TDomainEvent domainEvent) where TDomainEvent : IDomainEvent
        {
            Dispatcher.Dispatch(domainEvent);
        }
    }
}