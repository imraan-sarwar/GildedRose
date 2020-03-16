using Domain.Models;

namespace Domain.Inventory.Items
{
    public class Sulfuras : InventoryItem
    {
        public Sulfuras(SellingItem sellingItem) : base(sellingItem)
        {
            Process();
        }

        public void Process()
        {
            Validate();
        }
    }
}
