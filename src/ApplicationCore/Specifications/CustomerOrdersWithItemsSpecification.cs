using Effektiv.ApplicationCore.Entities.OrderAggregate;
using Effektiv.ApplicationCore.Helpers.Query;

namespace Effektiv.ApplicationCore.Specifications
{
    public class CustomerOrdersWithItemsSpecification : BaseSpecification<Order>
    {
        public CustomerOrdersWithItemsSpecification(string buyerId)
            : base(o => o.BuyerId == buyerId)
        {
            AddIncludes(query => query.Include(o => o.OrderItems).ThenInclude(i => i.ItemOrdered));
        }
    }
}
