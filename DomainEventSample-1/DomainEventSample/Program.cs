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
            
            User user = new User("bayram", "333");
            user.ChangePassword("333333");
            user.Activate();
        }
    }

}
