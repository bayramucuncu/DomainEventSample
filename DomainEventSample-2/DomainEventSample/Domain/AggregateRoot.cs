using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DomainEventSample.DomainEvent;

namespace DomainEventSample.Domain
{
    public abstract class AggregateRoot
    {
        private readonly Queue<IDomainEvent> uncommitedEvents = new Queue<IDomainEvent>();

        public IReadOnlyCollection<IDomainEvent> UncommitedEvents
        {
            get
            {
                return new ReadOnlyCollection<IDomainEvent>(uncommitedEvents.ToList());
            }
        }

        public void Apply(IDomainEvent domainevent)
        {
            uncommitedEvents.Enqueue(domainevent);

            //DomainEvents.Raise(domainevent);
        }
    }
}