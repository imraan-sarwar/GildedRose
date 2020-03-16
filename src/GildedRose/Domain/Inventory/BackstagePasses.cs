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
            else if (SellingDays <= 10 && SellingDays > 5)
            {
                Quality = Quality + 2;
            }
            else if (SellingDays <= 5 && SellingDays >= 1)
            {
                Quality = Quality + 3;
            }
            else
            {
                Quality = 0;
            }

            Validate();

        }
    }
}
