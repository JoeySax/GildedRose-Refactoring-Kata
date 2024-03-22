using GildedRoseKata.UpdateStrategies.Interfaces;
using System;

namespace GildedRoseKata.UpdateStrategies
{
    public class AgedBrieStrategy : IItemStrategy
    {
        public void UpdateItem(Item item)
        {
            item.SellIn -= 1;

            item.Quality = Math.Min(50, item.Quality + 1);
        }
    }
}
