using GildedRoseKata.UpdateStrategies.Interfaces;

namespace GildedRoseKata.UpdateStrategies
{
    public class LegendaryItemStrategy : IUpdateItemStrategy
    {
        public void UpdateItem(Item item)
        {
            item.SellIn = item.SellIn;
            item.Quality = item.Quality;
        }
    }
}
