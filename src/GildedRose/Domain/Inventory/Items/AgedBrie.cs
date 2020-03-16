using Domain.Models;

namespace Domain.Inventory.Items
{
    public class AgedBrie : InventoryItem
    {
        public AgedBrie(SellingItem sellingItem) : base(sellingItem)
        {
            Process();
        }

        public void Process()
        {
            DecreaseSellingDay();

            Quality = Quality + 1;

            Validate();
        }
    }
}
