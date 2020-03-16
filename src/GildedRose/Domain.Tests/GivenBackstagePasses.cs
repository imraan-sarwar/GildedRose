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

        public void SellingDaysIsLessThan10_Then_QualityIncreasesByTwo()
        {
            _sellingItem.Quality = 20;
            _sellingItem.SellingDays = 9;
            var b = new BackstagePasses(_sellingItem);
            Assert.AreEqual(22, b.Quality);
        }

        public void SellingDaysIs10_Then_QualityIncreasesByTwo()
        {
            _sellingItem.Quality = 20;
            _sellingItem.SellingDays = 10;
            var b = new BackstagePasses(_sellingItem);
            Assert.AreEqual(22, b.Quality);
        }

        [Test]
        public void SellingDaysIsLessThan5_Then_QualityIncreasesByThree()
        {
            _sellingItem.Quality = 20;
            _sellingItem.SellingDays = 4;
            var b = new BackstagePasses(_sellingItem);
            Assert.AreEqual(23, b.Quality);
        }

        [Test]
        public void SellingDaysIs5_Then_QualityIncreasesByThree()
        {
            _sellingItem.Quality = 20;
            _sellingItem.SellingDays = 5;
            var b = new BackstagePasses(_sellingItem);
            Assert.AreEqual(23, b.Quality);
        }

        [Test]
        public void SellingDaysIs1_Then_QualityIs0()
        {
            _sellingItem.Quality = 0;
            _sellingItem.SellingDays = 1;
            var b = new BackstagePasses(_sellingItem);
            Assert.AreEqual(0, b.Quality);
        }
    }
}
