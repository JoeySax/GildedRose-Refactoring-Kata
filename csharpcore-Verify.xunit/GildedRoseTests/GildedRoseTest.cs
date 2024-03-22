using GildedRoseTests.Setup;
using Xunit;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void Given_A_Normal_Item_When_A_Day_Passes_Then_The_SellIn_Value_Decreases_By_1()
        {
            new TestBed()
                .WithNormalItem(5, 10)
                .WithAssertion(Assertions.ShouldHaveTheCorrectSellin(4))
                .Run();
        }

        [Fact]
        public void Given_A_Normal_Item_When_A_Day_Passes_Then_The_Quality_Value_Decreases_By_1()
        {
            new TestBed()
                .WithNormalItem(5, 10)
                .WithAssertion(Assertions.ShouldHaveTheCorrectQuality(9))
                .Run();
        }

        [Fact]
        public void Given_A_Normal_Item_When_A_Day_Passes_And_The_Sellin_Value_Is_0_Then_The_Quality_Value_Decreases_By_2()
        {
            new TestBed()
                .WithNormalItem(0, 10)
                .WithAssertion(Assertions.ShouldHaveTheCorrectQuality(8))
                .Run();
        }

        [Fact]
        public void Given_A_Normal_Item_When_A_Day_Passes_And_The_Sellin_Value_Is_0_Then_The_Sellin_Value_Decreases_By_1()
        {
            new TestBed()
                .WithNormalItem(0, 10)
                .WithAssertion(Assertions.ShouldHaveTheCorrectSellin(-1))
                .Run();
        }

        [Fact]
        public void Given_A_Normal_Item_When_A_Day_Passes_And_Quality_Is_0_The_Quality_Should_Remain_At_0()
        {
            new TestBed()
                .WithNormalItem(5, 0)
                .WithAssertion(Assertions.ShouldHaveTheCorrectQuality(0))
                .Run();
        }

        [Fact]
        public void Given_The_Item_Is_Aged_Brie_When_A_Day_Passes_And_Quality_Is_50_The_Quality_Should_Remain_At_50()
        {
            new TestBed()
                .WithAgedBrie(5, 50)
                .WithAssertion(Assertions.ShouldHaveTheCorrectQuality(50))
                .Run();
        }

        [Fact]
        public void Given_The_Item_Is_Aged_Brie_When_A_Day_Passes_The_Sellin_Value_Should_Decrease_By_1()
        {
            new TestBed()
                .WithAgedBrie(5, 10)
                .WithAssertion(Assertions.ShouldHaveTheCorrectSellin(4))
                .Run();
        }

        [Fact]
        public void Given_The_Item_Is_Aged_Brie_When_A_Day_Passes_The_Quality_Value_Should_Increase_By_1()
        {
            new TestBed()
                .WithAgedBrie(5, 10)
                .WithAssertion(Assertions.ShouldHaveTheCorrectQuality(11))
                .Run();
        }

        [Fact]
        public void Given_The_Item_Is_Sulfuras_When_A_Day_Passes_The_Quality_Value_Should_Stay_The_Same()
        {
            new TestBed()
                .WithSulfuras(5, 80)
                .WithAssertion(Assertions.ShouldHaveTheCorrectQuality(80))
                .Run();
        }

        [Fact]
        public void Given_The_Item_Is_Sulfuras_When_A_Day_Passes_The_Sellin_Value_Should_Stay_The_Same()
        {
            new TestBed()
                .WithSulfuras(5, 80)
                .WithAssertion(Assertions.ShouldHaveTheCorrectSellin(5))
                .Run();
        }

        [Fact]
        public void Given_The_Item_Is_Backstage_Passes_When_A_Day_Passes_And_Quality_Is_50_The_Quality_Should_Remain_At_50()
        {
            new TestBed()
                .WithBackstagePass(5, 50)
                .WithAssertion(Assertions.ShouldHaveTheCorrectQuality(50))
                .Run();
        }

        [Fact]
        public void Given_The_Item_Is_Backstage_Passes_When_A_Day_Passes_And_The_Sellin_Value_Is_Over_10_The_Quality_Value_Should_Increase_By_1()
        {
            new TestBed()
                .WithBackstagePass(11, 20)
                .WithAssertion(Assertions.ShouldHaveTheCorrectQuality(21))
                .Run();
        }

        [Fact]
        public void Given_The_Item_Is_Backstage_Passes_When_A_Day_Passes_And_The_Sellin_Value_Is_Over_10_The_Sellin_Value_Should_Decrease_By_1()
        {
            new TestBed()
                .WithBackstagePass(11, 20)
                .WithAssertion(Assertions.ShouldHaveTheCorrectSellin(10))
                .Run();
        }

        [Fact]
        public void Given_The_Item_Is_Backstage_Passes_When_A_Day_Passes_And_The_Sellin_Value_Is_10_0r_Less_The_Quality_Value_Should_Increase_By_2()
        {
            new TestBed()
                .WithBackstagePass(10, 20)
                .WithAssertion(Assertions.ShouldHaveTheCorrectQuality(22))
                .Run();
        }

        [Fact]
        public void Given_The_Item_Is_Backstage_Passes_When_A_Day_Passes_And_The_Sellin_Value_Is_10_Or_Less_The_Sellin_Value_Should_Decrease_By_1()
        {
            new TestBed()
                .WithBackstagePass(10, 20)
                .WithAssertion(Assertions.ShouldHaveTheCorrectSellin(9))
                .Run();
        }

        [Fact]
        public void Given_The_Item_Is_Backstage_Passes_When_A_Day_Passes_And_The_Sellin_Value_Is_5_Or_Less_The_Quality_Value_Should_Increase_By_3()
        {
            new TestBed()
                .WithBackstagePass(5, 20)
                .WithAssertion(Assertions.ShouldHaveTheCorrectQuality(23))
                .Run();
        }

        [Fact]
        public void Given_The_Item_Is_Backstage_Passes_When_A_Day_Passes_And_The_Sellin_Value_Is_5_Or_Less_The_Sellin_Value_Should_Decrease_By_1()
        {
            new TestBed()
                .WithBackstagePass(5, 20)
                .WithAssertion(Assertions.ShouldHaveTheCorrectSellin(4))
                .Run();
        }

        [Fact]
        public void Given_The_Item_Is_Backstage_Passes_When_A_Day_Passes_And_The_Sellin_Value_Is_Less_Than_0_The_Quality_Value_Should_Decrease_To_0()
        {
            new TestBed()
                .WithBackstagePass(-1, 20)
                .WithAssertion(Assertions.ShouldHaveTheCorrectQuality(0))
                .Run();
        }

        [Fact]
        public void Given_The_Item_Is_Backstage_Passes_When_A_Day_Passes_And_The_Sellin_Value_Is_0_The_Sellin_Value_Should_Decrease_By_1()
        {
            new TestBed()
                .WithBackstagePass(0, 20)
                .WithAssertion(Assertions.ShouldHaveTheCorrectSellin(-1))
                .Run();
        }

        [Fact]
        public void Given_The_Item_Is_A_Conjured_Item_When_A_Day_Passes_The_Quality_Value_Should_Decrease_By_2()
        {
            new TestBed()
                .WithConjuredManaCake(5, 10)
                .WithAssertion(Assertions.ShouldHaveTheCorrectQuality(8))
                .Run();
        }

        [Fact]
        public void Given_The_Item_Is_A_Conjured_Item_When_A_Day_Passes_The_Sellin_Value_Should_Decrease_By_1()
        {
            new TestBed()
                .WithConjuredManaCake(5, 10)
                .WithAssertion(Assertions.ShouldHaveTheCorrectSellin(4))
                .Run();
        }
    }
}