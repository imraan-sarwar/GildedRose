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

        public void DecreaseSellingDay()
        {
            SellingDays = SellingDays - 1;
        }

        public void Validate()
        {
            if (Quality >= 50)
            {
                Quality = 50;
            }
            if (Quality <= 0)
            {
                Quality = 0;
            }
        }

    }
}
