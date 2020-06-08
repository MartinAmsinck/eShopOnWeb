using MediatR;
using Effektiv.Web.ViewModels;
using System.Collections.Generic;

namespace Effektiv.Web.Features.MyOrders
{
    public class GetMyOrders : IRequest<IEnumerable<OrderViewModel>>
    {
        public string UserName { get; set; }

        public GetMyOrders(string userName)
        {
            UserName = userName;
        }
    }
}
