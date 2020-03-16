using Domain.Inventory;
using Domain.Inventory.Items;
using Domain.Models;
using NUnit.Framework;
using System;

namespace Domain.Tests
{
    public class GivenBackstagePasses
    {
        private SellingItem _sellingItem;

        [SetUp]
        public void SetUp()
        {
            _sellingItem = new SellingItem()
            {
                Name = "Backstage passes",
                Quality = 1,
                SellingDays = 1
            };
        }

        [Test]
        public void SellingDaysDecreasesByOne()
        {
            var b = new BackstagePasses(_sellingItem);
            Assert.AreEqual(0, b.SellingDays);
        }
     
    }
}
