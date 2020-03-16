using Domain.Models;
using NUnit.Framework;

namespace Domain.Tests
{
    public class Tests
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
        public void Test1()
        {
        }
    }
}