using DomainEventSample.Command;
using DomainEventSample.Domain;

namespace DomainEventSample.CommandHandler
{
    public class ChangePasswordCommandHandler : ICommandHandler<ChangePasswordCommand>
    {
        private readonly IDomainRepository repository;

        public ChangePasswordCommandHandler(IDomainRepository repository)
        {
            this.repository = repository;
        }

        public void Execute(ChangePasswordCommand command)
        {
           repository.Save();
        }
    }
}