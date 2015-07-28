using System;
using DomainEventSample.DomainEvent;

namespace DomainEventSample.DomainEventHandler
{
    public class UserAccountDenormalizer : 
        IDomainEventHandler<PasswordChangedEvent>,
        IDomainEventHandler<UserActivatedEvent>,
        IDomainEventHandler<UserCreatedEvent>
    {
        public void Handle(PasswordChangedEvent domainEvent)
        {
            Console.WriteLine("User ({0}) Password changed.", domainEvent.User.Id);
        }

        public void Handle(UserActivatedEvent domainEvent)
        {
            Console.WriteLine("User ({0}) activated.", domainEvent.User.Id);
        }

        public void Handle(UserCreatedEvent domainEvent)
        {
            Console.WriteLine("User ({0}) created .", domainEvent.User.Id);
        }
    }
}