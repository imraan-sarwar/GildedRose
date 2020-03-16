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

        [Test]
        public void QualityIsNeverAbove50()
        {
            _sellingItem.Quality = 53;
            _sellingItem.SellingDays = 5;
            var b = new BackstagePasses(_sellingItem);
            Assert.AreEqual(50, b.Quality);
        }

        [Test]
        public void QualityIsNeverBelowZero()
        {
            _sellingItem.Quality = 0;
            var b = new BackstagePasses(_sellingItem);
            Assert.AreEqual(0, b.Quality);
        }

        [Test]
        public void SellingDaysIsGreaterThan10_Then_QualityIncreasesByOne()
        {
            _sellingItem.Quality = 15;
            _sellingItem.SellingDays = 15;
            var b = new BackstagePasses(_sellingItem);
            Assert.AreEqual(16, b.Quality);
        }

    }
}
