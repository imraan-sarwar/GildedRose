using Domain.Inventory;
using Domain.Models;
using NUnit.Framework;

namespace Domain.Tests
{
    public class GivenInvalid
    {
        private SellingItem _sellingItem;

        [SetUp]
        public void SetUp()
        {
            _sellingItem = new SellingItem()
            {
                Name = "Invalid",
                Quality = 1,
                SellingDays = 1
            };
        }

        [Test]
        public void DoesNotThrow()
        {
            Assert.DoesNotThrow(() => { InventoryFactory.Get(_sellingItem); });
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
        public void NameIsInvalidItem()
        {
            var s = InventoryFactory.Get(_sellingItem);
            Assert.AreEqual(s.Name, "NO SUCH ITEM");

        }
    }
}
