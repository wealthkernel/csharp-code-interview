using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace WealthKernel.ShoppingCart.Bus
{
    /// <summary>
    /// To use the command, you just need to inherit from Command
    /// and then you can create an ICommandHandler to do something with it
    /// </summary>
    public class ExampleCommand : Command
    {
        
    }
    
    public class ExampleCommandHandler : ICommandHandler<ExampleCommand>
    {
        public Task Handle(ExampleCommand notification, CancellationToken cancellationToken)
        {
            // Do something here!
            
            return Task.CompletedTask;
        }
    }
}
