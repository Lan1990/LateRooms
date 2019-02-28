using System;
using System.Collections.Generic;

namespace LateRooms
{
    public class Checkout
    {
        CheckoutA checkoutA = new CheckoutA();
        public Checkout()
        {
            CheckoutA checkoutA = new CheckoutA();
        }

        public void Scan(IStockKeepItem stockKeepItem)
        {

            if (stockKeepItem is StockKeepItemA)
            {
                checkoutA.Scan((StockKeepItemA)stockKeepItem);
            }
        }

        public int GetTotalPrice()
        {
            return checkoutA.GetTotalPrice();
        }
    }
}