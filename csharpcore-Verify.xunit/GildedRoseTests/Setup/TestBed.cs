using GildedRoseKata;
using JetBrains.Annotations;
using System.Collections.Generic;

namespace GildedRoseTests.Setup
{
    internal delegate void AssertionCall(Item item);

    internal class TestBed
    {
        private List<Item> items;
        private AssertionCall? _itemAssertion;

        public TestBed()
        {
            items = new List<Item>();
        }

        internal void Run()
        {
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            _itemAssertion.Invoke(items[0]);
        }

        internal TestBed WithItem(string name, int sellIn, int quality)
        {
            items.Add(new Item { Name = name, SellIn = sellIn, Quality = quality });
            return this;
        }

        internal TestBed WithNormalItem(int sellIn, int quality)
        {
            WithItem("Normal Item", sellIn, quality);
            return this;
        }

        internal TestBed WithAgedBrie(int sellIn, int quality)
        {
            WithItem("Aged Brie", sellIn, quality);
            return this;
        }

        internal TestBed WithSulfuras(int sellIn, int quality)
        {
            WithItem("Sulfuras, Hand of Ragnaros", sellIn, quality);
            return this;
        }

        internal TestBed WithBackstagePass(int sellIn, int quality)
        {
            WithItem("Backstage passes to a TAFKAL80ETC concert", sellIn, quality);
            return this;
        }

        internal TestBed WithConjuredManaCake(int sellIn, int quality)
        {
            WithItem("Conjured Mana Cake", sellIn, quality);
            return this;
        }

        [AssertionMethod]
        public TestBed WithAssertion(AssertionCall assertions)
        {
            _itemAssertion = item =>
            {
                assertions(item);
            };

            return this;
        }
    }
}
