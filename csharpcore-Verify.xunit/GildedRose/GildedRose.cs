using GildedRoseKata.Factories;
using GildedRoseKata.Factories.Interfaces;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        private  IList<Item> Items;
        private readonly IItemStrategyFactory _itemStrategyFactory;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
            _itemStrategyFactory = new ItemStrategyFactory();
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                var strategy = _itemStrategyFactory.Create(Items[i].Name);
                strategy.UpdateItem(Items[i]);
            }
        }
    }
}
