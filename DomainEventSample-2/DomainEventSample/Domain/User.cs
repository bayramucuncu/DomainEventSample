using System;
using DomainEventSample.DomainEvent;

namespace DomainEventSample.Domain
{
    public class User: AggregateRoot
    {
        public Guid Id { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public bool IsActivated { get; private set; }

        public User()
            :this(string.Empty,string.Empty)
        {
        }

        public User(string username, string password)
            :this(Guid.NewGuid(), username, password)
        {
            Apply(new UserCreatedEvent(this));
        }

        public User(Guid id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
        }

        public void ChangePassword(string password)
        {
            if(string.IsNullOrEmpty(password))
                throw new ArgumentNullException("password");

            Password = Password;

            Apply(new PasswordChangedEvent(this));
        }

        public void Activate()
        {
            IsActivated = false;

            Apply(new UserActivatedEvent(this));
        }
    }
}