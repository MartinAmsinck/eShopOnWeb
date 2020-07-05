using Effektiv.Web.Extensions;
using Xunit;

namespace Effektiv.UnitTests.Web.Extensions.CacheHelpersTests
{
    public class GenerateTypesCacheKey
    {
        [Fact]
        public void ReturnsTypesCacheKey()
        {
            var result = CacheHelpers.GenerateTypesCacheKey();

            Assert.Equal("types", result);
        }
    }
}
