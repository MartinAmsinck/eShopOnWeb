using Effektiv.Web.Extensions;
using Xunit;

namespace Effektiv.UnitTests.Web.Extensions.CacheHelpersTests
{
    public class GenerateBrandsCacheKey
    {
        [Fact]
        public void ReturnsBrandsCacheKey()
        {
            var result = CacheHelpers.GenerateBrandsCacheKey();

            Assert.Equal("brands", result);
        }
    }
}
