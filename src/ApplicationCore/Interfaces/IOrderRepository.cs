using Effektiv.ApplicationCore.Entities.OrderAggregate;
using System.Threading.Tasks;

namespace Effektiv.ApplicationCore.Interfaces
{

    public interface IOrderRepository : IAsyncRepository<Order>
    {
        Task<Order> GetByIdWithItemsAsync(int id);
    }
}
