using System;
using DomainEventSample.DomainEvent;

namespace DomainEventSample.DomainEventHandler
{
    public class UserCreatedEventHandler: IDomainEventHandler<UserCreatedEvent>
    {
        public void Handle(UserCreatedEvent domainEvent)
        {
            Console.WriteLine("User ({0}) created .", domainEvent.User.Id);
        }
    }
}