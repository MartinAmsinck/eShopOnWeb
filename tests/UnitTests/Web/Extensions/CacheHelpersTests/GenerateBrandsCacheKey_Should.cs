using Effektiv.Web.Extensions;
using Xunit;

namespace Effektiv.UnitTests.Web.Extensions.CacheHelpersTests
{
    public class GenerateBrandsCacheKey_Should
    {
        [Fact]
        public void ReturnBrandsCacheKey()
        {
            var result = CacheHelpers.GenerateBrandsCacheKey();

            Assert.Equal("brands", result);
        }
    }
}
