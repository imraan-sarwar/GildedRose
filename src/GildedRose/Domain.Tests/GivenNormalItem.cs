

using Domain.Inventory;
using Domain.Models;
using NUnit.Framework;

namespace Domain.Tests
{
    class GivenNormalItem
    {
        private SellingItem _sellingItem;

        [SetUp]
        public void SetUp()
        {
            _sellingItem = new SellingItem()
            {
                Name = "Normal Item",
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
        public void QualityDecreasesByOne()
        {
            var s = InventoryFactory.Get(_sellingItem);
            Assert.AreEqual(0, s.Quality);
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

        [Test]
        public void QualityDegradesTwiceAsFastWhenSellingDaysHasPassed()
        {
            _sellingItem.SellingDays = -1;
            _sellingItem.Quality = 5;
            var s = InventoryFactory.Get(_sellingItem);
            Assert.AreEqual(3, s.Quality);
        }
    }
}
