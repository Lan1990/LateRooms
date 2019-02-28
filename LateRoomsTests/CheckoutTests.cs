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
            var itemA = new StockKeepItemA();
            var itemB = new StockKeepItemA();


            var checkout = new Checkout();
            checkout.Scan(itemA);
            checkout.Scan(itemB);

            var totalPrice = checkout.GetTotalPrice();


            Assert.AreEqual(100, totalPrice);
        }

        [TestMethod]
        public void Adding3ItemsOfSameTypeAGivesDiscountPrice()
        {
            var itemA1 = new StockKeepItemA();
            var itemA2 = new StockKeepItemA();
            var itemA3 = new StockKeepItemA();


            var checkout = new Checkout();
            checkout.Scan(itemA1);
            checkout.Scan(itemA2);
            checkout.Scan(itemA3);

            var totalPrice = checkout.GetTotalPrice();

            Assert.AreEqual(130, totalPrice);


        }

    }
}
