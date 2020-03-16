
using Domain.Inventory;
using Domain.Inventory.Items;
using Domain.Models;
using System;
using System.Collections.Generic;


namespace ConsoleApp4
{
    class RunMe
    {
        static void Main(string[] args)
        {
            var s = new List<SellingItem>()
            {
                new SellingItem() { Name = "Aged Brie", Quality = 1, SellingDays = 1 },
                new SellingItem() { Name = "Backstage passes", Quality = 2, SellingDays = -1 },
                new SellingItem() { Name = "Backstage passes", Quality = 2, SellingDays = 9 },
                new SellingItem() { Name = "Sulfuras", Quality = 2, SellingDays = 2 },
                new SellingItem() { Name = "Normal Item", Quality = 55, SellingDays = -1 },
                new SellingItem() { Name = "Normal Item", Quality = 2, SellingDays = 2 },
                new SellingItem() { Name = "INVALID ITEM", Quality = 2, SellingDays = 2 },
                new SellingItem() { Name = "Conjured", Quality = 2, SellingDays = 2},
                new SellingItem() { Name = "Conjured", Quality = 5, SellingDays = -1 },
            };
            s.ForEach(x => {
                var i = InventoryFactory.Get(x);
                if (i is Invalid)
                {
                    Console.WriteLine($"{i.Name}");
                }
                else
                {
                    Console.WriteLine($"{i.Name} {i.SellingDays} {i.Quality}");
                }

            });
        }
    }
}

