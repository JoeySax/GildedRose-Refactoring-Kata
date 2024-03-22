using GildedRoseKata.UpdateStrategies.Interfaces;
using System;

namespace GildedRoseKata.UpdateStrategies
{
    public class ConjuredItemStrategy : IItemStrategy
    {
        public void UpdateItem(Item item)
        {
            item.SellIn--;

            int decreaseFactor = item.SellIn >= 0 ? 2 : 4;
            int updatedQuality = Math.Max(0, item.Quality - decreaseFactor);

            item.Quality = updatedQuality;
        }
    }
}
