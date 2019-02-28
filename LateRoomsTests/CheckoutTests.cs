using LateRooms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LateRoomsTests
{
    [TestClass]
    public class CheckoutTests
    {
        [TestMethod]
        public void AddingItemsToCheckoutAddsUpTotalPrice()
        {
            var itemA = new StockKeepItem {Price = 50 };
            var itemB = new StockKeepItem {Price = 30 };


            var checkout = new Checkout();
            checkout.Scan(itemA);
            checkout.Scan(itemB);

            var totalPrice = checkout.GetTotalPrice();


            Assert.AreEqual(80, totalPrice);
        }

        [TestMethod]
        public void Adding3ItemsOfSameTypeAGivesDiscountPrice()
        {
            var itemA1 = new StockKeepItemA { Price = 50 };
            var itemA2 = new StockKeepItemA { Price = 50 };
            var itemA3 = new StockKeepItemA { Price = 50 };


            var checkout = new Checkout();
            checkout.Scan(itemA1);
            checkout.Scan(itemA2);
            checkout.Scan(itemA3);

            var totalPrice = checkout.GetTotalPrice();

            Assert.AreEqual(130, totalPrice);


        }

    }
}
