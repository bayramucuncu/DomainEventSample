using DomainEventSample.DomainEvent;

namespace DomainEventSample.DomainEventHandler
{
    public interface IDomainEventDispatcher
    {
        void Dispatch<TDomainEvent>(TDomainEvent domainEvent) where TDomainEvent : IDomainEvent;
    }
}