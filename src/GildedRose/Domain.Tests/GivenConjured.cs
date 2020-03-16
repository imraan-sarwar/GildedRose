using Domain.Inventory;
using Domain.Models;
using NUnit.Framework;
using System;

namespace Domain.Tests
{
    public class GivenConjured
    {
        private SellingItem _sellingItem;

        [SetUp]
        public void SetUp()
        {
            _sellingItem = new SellingItem()
            {
                Name = "Conjured",
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
        public void QualityDecreasesByTwo()
        {
            _sellingItem.SellingDays = 5;
            _sellingItem.Quality = 5;
            var s = InventoryFactory.Get(_sellingItem);
            Assert.AreEqual(3, s.Quality);
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
            _sellingItem.Quality = 0;
            var s = InventoryFactory.Get(_sellingItem);
            Assert.AreEqual(0, s.Quality);
        }
    }
}
