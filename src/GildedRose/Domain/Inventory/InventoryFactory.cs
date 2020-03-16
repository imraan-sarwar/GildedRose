using Domain.Inventory.Items;
using Domain.Models;
using System;

namespace Domain.Inventory
{
    public static class InventoryFactory
    {
        public static InventoryItem Get(SellingItem item)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                    return new AgedBrie(item);
                case "Backstage passes":
                    return new BackstagePasses(item);
                case "Normal Item":
                    return new NormalItem(item);
            }
            return new Invalid(item);
        }
    }
}
