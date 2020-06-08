using Effektiv.Web.ViewModels;
using System.Threading.Tasks;

namespace Effektiv.Web.Interfaces
{
    public interface ICatalogItemViewModelService
    {
        Task UpdateCatalogItem(CatalogItemViewModel viewModel);
    }
}
