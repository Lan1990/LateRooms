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


            var checkout = new FinalCheckout();
            checkout.Scan(itemA);
            checkout.Scan(itemB);

            var totalPrice = checkout.GetTotalPrice();


            Assert.AreEqual(100, totalPrice);
        }

        [TestMethod]
        public void AddingDifferentItemsToCheckoutAddsUpTotalPrice()
        {
            var itemA = new StockKeepItemA();
            var itemB = new StockKeepItemB();


            var checkout = new FinalCheckout();
            checkout.Scan(itemA);
            checkout.Scan(itemB);

            var totalPrice = checkout.GetTotalPrice();


            Assert.AreEqual(80, totalPrice);
        }

        [TestMethod]
        public void Adding3ItemsOfSameTypeAGivesDiscountPrice()
        {
            var itemA1 = new StockKeepItemA();
            var itemA2 = new StockKeepItemA();
            var itemA3 = new StockKeepItemA();


            var checkout = new FinalCheckout();
            checkout.Scan(itemA1);
            checkout.Scan(itemA2);
            checkout.Scan(itemA3);

            var totalPrice = checkout.GetTotalPrice();

            Assert.AreEqual(130, totalPrice);
        }

        [TestMethod]
        public void Adding4ItemsOfSameTypeAGivesDiscountPricePlus1FullPrice()
        {
            var itemA1 = new StockKeepItemA();
            var itemA2 = new StockKeepItemA();
            var itemA3 = new StockKeepItemA();
            var itemA4 = new StockKeepItemA();


            var checkout = new FinalCheckout();
            checkout.Scan(itemA1);
            checkout.Scan(itemA2);
            checkout.Scan(itemA3);
            checkout.Scan(itemA4);

            var totalPrice = checkout.GetTotalPrice();

            Assert.AreEqual(180, totalPrice);
        }


        [TestMethod]
        public void AddingMixedItemsWithDiscounts()
        {
            var itemA1 = new StockKeepItemA();
            var itemA2 = new StockKeepItemA();
            var itemA3 = new StockKeepItemA();
            var itemA4 = new StockKeepItemA();
            var itemB1 = new StockKeepItemB();
            var itemB2 = new StockKeepItemB();
            var itemB3 = new StockKeepItemB();
            var itemB4 = new StockKeepItemB();
            var itemB5 = new StockKeepItemB();


            var checkout = new FinalCheckout();
            checkout.Scan(itemA1);
            checkout.Scan(itemA2);
            checkout.Scan(itemA3);
            checkout.Scan(itemA4);

            checkout.Scan(itemB1);
            checkout.Scan(itemB2);
            checkout.Scan(itemB3);
            checkout.Scan(itemB4);
            checkout.Scan(itemB5);

            var totalPrice = checkout.GetTotalPrice();

            Assert.AreEqual(300, totalPrice);
        }

    }
}
