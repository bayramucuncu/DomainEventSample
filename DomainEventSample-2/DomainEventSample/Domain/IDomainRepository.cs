namespace DomainEventSample.Domain
{
    public interface IDomainRepository
    {
        void Add(AggregateRoot aggregateRoot);
        void Save();
    }
}