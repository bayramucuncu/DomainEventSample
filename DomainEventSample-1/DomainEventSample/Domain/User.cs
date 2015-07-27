using System;
using DomainEventSample.DomainEvent;

namespace DomainEventSample.Domain
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public bool IsActivated { get; private set; }

        public User(Guid id)
        {
            Id = id;
        }

        public User(string username, string password)
        {
            Id = Guid.NewGuid();
            Username = username;
            Password = password;

            DomainEvents.Raise(new UserCreatedEvent(this));
        }

        public void ChangePassword(string password)
        {
            if(string.IsNullOrEmpty(password))
                throw new ArgumentNullException("password");

            Password = Password;

            DomainEvents.Raise(new PasswordChangedEvent(this));
        }

        public void Activate()
        {
            IsActivated = false;

            DomainEvents.Raise(new UserActivatedEvent(this));
        }
    }
}