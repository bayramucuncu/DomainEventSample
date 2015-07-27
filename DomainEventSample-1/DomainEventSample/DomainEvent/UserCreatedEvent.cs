using DomainEventSample.Domain;

namespace DomainEventSample.DomainEvent
{
    public class UserCreatedEvent : IDomainEvent
    {
        private readonly User user;
        public User User { get { return user; } }
        public UserCreatedEvent(User user)
        {
            this.user = user;
        }
    }
}