using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        foreach (var item in Items)
        {
            IItemStrategy strategy = ItemStrategyFactory.GetStrategy(item);
            strategy.Update(item);
        }
    }
}
public interface IItemStrategy
{
    void Update(Item item);
}

public class RegularItemStrategy : IItemStrategy
{
    public void Update(Item item)
    {
        if (item.Quality > 0)
            item.Quality--;

        item.SellIn--;

        if (item.SellIn < 0 && item.Quality > 0)
            item.Quality--;
    }
}

public static class ItemStrategyFactory
{
    public static IItemStrategy GetStrategy(Item item)
    {
        return item.Name switch
        {
            "Aged Brie" => new AgedBrieStrategy(),
            "Backstage passes to a TAFKAL80ETC concert" => new BackstagePassStrategy(),
            "Sulfuras, Hand of Ragnaros" => new SulfurasStrategy(),
            _ => new RegularItemStrategy()
        };
    }
}