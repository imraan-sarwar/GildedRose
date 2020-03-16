using Domain.Models;

namespace Domain.Inventory.Items
{
    public class NormalItem : InventoryItem
    {
        public NormalItem(SellingItem sellingItem) : base(sellingItem)
        {
            Process();
        }

        public void Process()
        {
            DecreaseSellingDay();

            if (Quality > 0)
            {
                Quality = Quality - 1;
            }
            if (SellingDays < 0 && Quality > 0)
            {
                Quality = Quality - 1;
            }

            Validate();
        }
    }
}
