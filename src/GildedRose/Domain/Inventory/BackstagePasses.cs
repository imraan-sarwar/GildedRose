using Domain.Models;

namespace Domain.Inventory.Items
{
    public class BackstagePasses : InventoryItem
    {

        public BackstagePasses(SellingItem sellingItem) : base(sellingItem)
        {
            Process();
        }

        public void Process()
        {
            DecreaseSellingDay();

            if (SellingDays > 10)
            {
                Quality = Quality + 1;
            }

            Validate();

        }
    }
}
