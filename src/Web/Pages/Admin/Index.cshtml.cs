using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Effektiv.ApplicationCore.Constants;
using Effektiv.Web.Extensions;
using Effektiv.Web.Services;
using Effektiv.Web.ViewModels;
using Microsoft.Extensions.Caching.Memory;
using System.Threading.Tasks;

namespace Effektiv.Web.Pages.Admin
{
    [Authorize(Roles = AuthorizationConstants.Roles.ADMINISTRATORS)]
    public class IndexModel : PageModel
    {
        private readonly ICatalogViewModelService _catalogViewModelService;
        private readonly IMemoryCache _cache;

        public IndexModel(ICatalogViewModelService catalogViewModelService, IMemoryCache cache)
        {
            _catalogViewModelService = catalogViewModelService;
            _cache = cache;
        }

        public CatalogIndexViewModel CatalogModel { get; set; } = new CatalogIndexViewModel();

        public async Task OnGet(CatalogIndexViewModel catalogModel, int? pageId)
        {
            var cacheKey = CacheHelpers.GenerateCatalogItemCacheKey(pageId.GetValueOrDefault(), Constants.ITEMS_PER_PAGE, catalogModel.BrandFilterApplied, catalogModel.TypesFilterApplied);

            _cache.Remove(cacheKey);

            CatalogModel = await _catalogViewModelService.GetCatalogItems(pageId.GetValueOrDefault(), Constants.ITEMS_PER_PAGE, catalogModel.BrandFilterApplied, catalogModel.TypesFilterApplied);
        }
    }
}
