using System;
using DomainEventSample.Domain;

namespace DomainEventSample.DomainEvent
{
    public class UserActivatedEvent : IDomainEvent
    {
        private readonly User user;
        public User User { get { return user; } }
        public UserActivatedEvent(User user)
        {
            this.user = user;
        }
    }
}