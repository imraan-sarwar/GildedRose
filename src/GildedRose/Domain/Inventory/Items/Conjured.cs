using Domain.Models;

namespace Domain.Inventory.Items
{
    public class Conjured : InventoryItem
    {

        public Conjured(SellingItem sellingItem) : base(sellingItem)
        {
            Process();
        }

        public void Process()
        {
            DecreaseSellingDay();

            Quality = Quality - 2;

            if (SellingDays < 0)
            {
                Quality = Quality - 2;
            }

            Validate();
        }
    }
}
