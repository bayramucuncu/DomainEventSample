using DomainEventSample.Domain;

namespace DomainEventSample.DomainEvent
{
    public class PasswordChangedEvent : IDomainEvent
    {
        private readonly User user;
        public User User {get { return user; }}
        public PasswordChangedEvent(User user)
        {
            this.user = user;
        }
    }
}