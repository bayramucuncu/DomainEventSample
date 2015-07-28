using DomainEventSample.Command;

namespace DomainEventSample.CommandHandler
{
    public interface ICommandHandler<in TCommand> where TCommand: ICommand
    {
        void Execute(TCommand command);
    }
}