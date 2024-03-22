using GildedRoseKata.Factories.Interfaces;
using GildedRoseKata.UpdateStrategies;
using GildedRoseKata.UpdateStrategies.Interfaces;

namespace GildedRoseKata.Factories
{
    public class ItemStrategyFactory : IItemStrategyFactory
    {
        public IUpdateItemStrategy Create(string name)
        {
            switch (name)
            {
                case "Aged Brie":
                    return new AgedBrieStrategy();
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackstagePassesStrategy();
                case "Sulfuras, Hand of Ragnaros":
                    return new LegendaryItemStrategy();
                case "Conjured Mana Cake":
                    return new CounjuredItemStrategy();
                default:
                    return new NormalItemStrategy();
            }
        }
    }
}
