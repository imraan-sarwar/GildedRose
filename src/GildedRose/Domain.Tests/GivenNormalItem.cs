using Domain.Inventory.Items;
using Domain.Models;
using NUnit.Framework;

namespace Domain.Tests
{
    public class GivenNormalItem
    {
        private SellingItem _sellingItem;

        [SetUp]
        public void Setup()
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
            var n = new NormalItem(_sellingItem);
            Assert.AreEqual(0, n.SellingDays);
        }

        [Test]
        public void QualityDecreasesByOne()
        {
            var n = new NormalItem(_sellingItem);
            Assert.AreEqual(0, n.Quality);
        }

        [Test]
        public void QualityIsNeverAbove50()
        {
            _sellingItem.Quality = 53;
            var n = new NormalItem(_sellingItem);
            Assert.AreEqual(50, n.Quality);
        }

        [Test]
        public void QualityIsNeverBelowZero()
        {
            _sellingItem.Quality = 0;
            var n = new NormalItem(_sellingItem);
            Assert.AreEqual(0, n.Quality);
        }

        [Test]
        public void QualityDegradesTwiceAsFastWhenSellingDaysHasPassed()
        {
            _sellingItem.SellingDays = -1;
            _sellingItem.Quality = 5;
            var n = new NormalItem(_sellingItem);
            Assert.AreEqual(3, n.Quality);
        }
    }
}