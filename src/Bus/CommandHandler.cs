using MediatR;

namespace WealthKernel.ShoppingCart.Bus
{
    public interface ICommandHandler<in T> : INotificationHandler<T> where T : INotification
    {
    }
}
