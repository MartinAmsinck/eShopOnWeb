using Effektiv.Web.Pages.Basket;
using System.Threading.Tasks;

namespace Effektiv.Web.Interfaces
{
    public interface IBasketViewModelService
    {
        Task<BasketViewModel> GetOrCreateBasketForUser(string userName);
    }
}
