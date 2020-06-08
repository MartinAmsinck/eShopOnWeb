using Effektiv.ApplicationCore.Entities.OrderAggregate;
using System.Threading.Tasks;

namespace Effektiv.ApplicationCore.Interfaces
{
    public interface IOrderService
    {
        Task CreateOrderAsync(int basketId, Address shippingAddress);
    }
}
