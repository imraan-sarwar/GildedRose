using Domain.Models;

namespace Domain.Inventory.Items
{
    public class NormalItem : InventoryItem
    {
        public NormalItem(SellingItem sellingItem) : base(sellingItem)
        {
            SellingDays = SellingDays - 1;
        }
    }
}
