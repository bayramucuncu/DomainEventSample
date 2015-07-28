using System.Collections.Generic;
using DomainEventSample.DomainEvent;

namespace DomainEventSample.Domain
{
    public class DomainRepository : IDomainRepository
    {
        private readonly IList<AggregateRoot> aggregateRoots;

        public DomainRepository()
        {
            aggregateRoots = new List<AggregateRoot>();
        }

        public void Add(AggregateRoot aggregateRoot)
        {
            aggregateRoots.Add(aggregateRoot);
        }

        public void Save()
        {
            foreach (var aggregateRoot in aggregateRoots)
            {
                foreach (var domainEventHandler in aggregateRoot.UncommitedEvents)
                {
                    DomainEvents.Raise(domainEventHandler);           
                }
            }
        }
    }
}