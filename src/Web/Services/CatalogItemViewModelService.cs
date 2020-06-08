using Effektiv.ApplicationCore.Entities;
using Effektiv.ApplicationCore.Interfaces;
using Effektiv.Web.Interfaces;
using Effektiv.Web.ViewModels;
using System.Threading.Tasks;

namespace Effektiv.Web.Services
{
    public class CatalogItemViewModelService : ICatalogItemViewModelService
    {
        private readonly IAsyncRepository<CatalogItem> _catalogItemRepository;

        public CatalogItemViewModelService(IAsyncRepository<CatalogItem> catalogItemRepository)
        {
            _catalogItemRepository = catalogItemRepository;
        }

        public async Task UpdateCatalogItem(CatalogItemViewModel viewModel)
        {
            var existingCatalogItem = await _catalogItemRepository.GetByIdAsync(viewModel.Id);
            existingCatalogItem.Update(viewModel.Name, viewModel.Price);
            await _catalogItemRepository.UpdateAsync(existingCatalogItem);
        }
    }
}
