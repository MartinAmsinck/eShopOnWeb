using Ardalis.Specification;
using Ardalis.Specification.QueryExtensions.Include;
using Effektiv.ApplicationCore.Entities.OrderAggregate;

namespace Effektiv.ApplicationCore.Specifications
{
    public class CustomerOrdersWithItemsSpecification : BaseSpecification<Order>
    {
        public CustomerOrdersWithItemsSpecification(string buyerId)
            : base(o => o.BuyerId == buyerId)
        {
            AddIncludes(query => query.Include(o => o.OrderItems)
            .ThenInclude(i => i.ItemOrdered));
        }
    }
}
