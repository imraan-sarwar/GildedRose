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
                case "Backstage passes":
                    return new BackstagePasses(item);
                case "Normal Item":
                    return new NormalItem(item);
            }
            throw new Exception("Invalid!");
        }
    }
}
