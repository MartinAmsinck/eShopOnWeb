using Effektiv.Web.Extensions;
using Xunit;

namespace Effektiv.UnitTests.Web.Extensions.CacheHelpersTests
{
    public class GenerateTypesCacheKey_Should
    {
        [Fact]
        public void ReturnTypesCacheKey()
        {
            var result = CacheHelpers.GenerateTypesCacheKey();

            Assert.Equal("types", result);
        }
    }
}
