using System;
using DomainEventSample.DomainEvent;

namespace DomainEventSample.DomainEventHandler
{
    public class UserActivatedEventHandler : IDomainEventHandler<UserActivatedEvent>
    {
        public void Handle(UserActivatedEvent domainEvent)
        {
            Console.WriteLine("User ({0}) activated.", domainEvent.User.Id);
        }
    }
}