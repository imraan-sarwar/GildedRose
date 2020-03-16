using Domain.Models;

namespace Domain.Inventory
{
    public abstract class InventoryItem
    {
        public string Name { get; set; }

        public int Quality { get; set; }

        public int SellingDays { get; set; }

        public InventoryItem(SellingItem sellingItem)
        {
            Quality = sellingItem.Quality;
            SellingDays = sellingItem.SellingDays;
            Name = sellingItem.Name;
        }

    }
}
