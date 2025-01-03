using System;

namespace GildedRoseKata;

public class AgedBrieStrategy : IItemStrategy
{
    public void Update(Item item)
    {
        if (item.Quality < 50)
            item.Quality++;

        item.SellIn--;

        if (item.SellIn < 0 && item.Quality < 50)
            item.Quality++;
    }
}