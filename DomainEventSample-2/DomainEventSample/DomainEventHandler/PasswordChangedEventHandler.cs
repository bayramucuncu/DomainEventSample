using System;
using DomainEventSample.DomainEvent;

namespace DomainEventSample.DomainEventHandler
{
    public class PasswordChangedEventHandler : IDomainEventHandler<PasswordChangedEvent>
    {
        public void Handle(PasswordChangedEvent domainEvent)
        {
            Console.WriteLine("User ({0}) Password changed.", domainEvent.User.Id);
        }
    }
}