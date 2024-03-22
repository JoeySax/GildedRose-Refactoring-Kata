using Xunit;

namespace GildedRoseTests.Setup
{
    internal class Assertions
    {
        internal static AssertionCall ShouldHaveTheCorrectQuality(int expectedQuality)
            => (item) =>
        {
            Assert.Equal(expectedQuality, item.Quality);
        };

        internal static AssertionCall ShouldHaveTheCorrectSellin(int expectedSellIn)
        => (item) =>
        {
            Assert.Equal(expectedSellIn, item.SellIn);
        };
    }
}
