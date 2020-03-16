using Domain.Models;

namespace Domain.Inventory.Items
{
    public class Invalid : InventoryItem
    {
        const string _name = "NO SUCH ITEM";

        public Invalid(SellingItem sellingItem) : base(sellingItem)
        {
            Name = _name;
        }
    }
}
