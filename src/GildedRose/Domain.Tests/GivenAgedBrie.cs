using Domain.Inventory;
using Domain.Models;
using NUnit.Framework;
using System;

namespace Domain.Tests
{
    public class GivenAgedBrie
    {
        private SellingItem _sellingItem;

        [SetUp]
        public void SetUp()
        {
            _sellingItem = new SellingItem()
            {
                Name = "Aged Brie",
                Quality = 1,
                SellingDays = 1
            };
        }

        [Test]
        public void SellingDaysDecreasesByOne()
        {
            var s = InventoryFactory.Get(_sellingItem);
            Assert.AreEqual(0, s.SellingDays);
        }

        [Test]
        public void QualityIncreasesByOne()
        {
            var s = InventoryFactory.Get(_sellingItem);
            Assert.AreEqual(2, s.Quality);
        }

        [Test]
        public void QualityIsNeverAbove50()
        {
            _sellingItem.Quality = 53;
            var s = InventoryFactory.Get(_sellingItem);
            Assert.AreEqual(50, s.Quality);
        }

        [Test]
        public void QualityIsNeverBelowZero()
        {
            _sellingItem.Quality = 60;
            var s = InventoryFactory.Get(_sellingItem);
            Assert.AreEqual(50, s.Quality);
        }

    }
}
