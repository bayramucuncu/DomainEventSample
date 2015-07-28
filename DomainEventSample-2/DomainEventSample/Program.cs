using DomainEventSample.Command;
using DomainEventSample.CommandHandler;
using DomainEventSample.DependencyInjection.NinjectDI;
using DomainEventSample.Domain;
using Ninject;

namespace DomainEventSample
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel(new ServiceModule());
            IDomainRepository repository = kernel.Get<IDomainRepository>();

            User user = new User("bayram", "333");
            user.ChangePassword("333333");
            user.Activate();
            
            repository.Add(user);

            ChangePasswordCommand command = new ChangePasswordCommand();
            command.Password = "123456";

            ChangePasswordCommandHandler handler = new ChangePasswordCommandHandler(repository);
            handler.Execute(command);
        }
    }

}
