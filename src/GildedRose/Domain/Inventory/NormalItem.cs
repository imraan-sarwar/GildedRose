﻿using Domain.Models;

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
            SellingDays = SellingDays - 1;

            if (Quality > 0)
            {
                Quality = Quality - 1;
            }
            if (SellingDays < 0 && Quality > 0)
            {
                Quality = Quality - 1;
            }

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