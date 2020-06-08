﻿using Effektiv.Web;
using Effektiv.Web.Extensions;
using Xunit;

namespace Effektiv.UnitTests.Web.Extensions.CacheHelpersTests
{
    public class GenerateCatalogItemCacheKey_Should
    {
        [Fact]
        public void ReturnCatalogItemCacheKey()
        {
            var pageIndex = 0;
            int? brandId = null;
            int? typeId = null;

            var result = CacheHelpers.GenerateCatalogItemCacheKey(pageIndex, Constants.ITEMS_PER_PAGE, brandId, typeId);

            Assert.Equal("items-0-10--", result);
        }
    }
}
