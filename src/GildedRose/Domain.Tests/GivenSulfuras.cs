using Domain.Inventory;
using Domain.Models;
using NUnit.Framework;
using System;

namespace Domain.Tests
{
    public class GivenSulfuras
    {
        private SellingItem _sellingItem;

        [SetUp]
        public void SetUp()
        {
            _sellingItem = new SellingItem()
            {
                Name = "Sulfuras",
                Quality = 1,
                SellingDays = 1
            };
        }

        [Test]
        public void DaysDoNotDecrease()
        {
            var s = InventoryFactory.Get(_sellingItem);
            Assert.AreEqual(1, s.SellingDays);
        }

        [Test]
        public void QualityDoesNotDecrease()
        {
            var s = InventoryFactory.Get(_sellingItem);
            Assert.AreEqual(1, s.Quality);
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
