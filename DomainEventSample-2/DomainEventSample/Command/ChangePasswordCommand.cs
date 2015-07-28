namespace DomainEventSample.Command
{
    public class ChangePasswordCommand : ICommand
    {
        public string Password { get; set; }
    }
}