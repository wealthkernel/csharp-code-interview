using System.Threading.Tasks;
using MediatR;

namespace WealthKernel.ShoppingCart.Bus
{
    public class SimpleBus
    {
        private readonly IMediator _mediator;

        public SimpleBus(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        public async Task Send(Command command)
        {
            await _mediator.Publish(command);
        }
    }
}
