using System;
using System.Collections.Generic;

namespace LateRooms
{
    public class Checkout
    {
        CheckoutA checkoutA = new CheckoutA();
        CheckoutB checkoutB = new CheckoutB();

  

        public void Scan(IStockKeepItem stockKeepItem)
        {

            switch (stockKeepItem)
            {
                case StockKeepItemA a:
                    checkoutA.Scan(a);
                    break;
                case StockKeepItemB b:
                    checkoutB.Scan(b);
                    break;
                default:
                    break;
            }
        }

        public int GetTotalPrice()
        {
            return checkoutA.GetTotalPrice() + checkoutB.GetTotalPrice();
        }
    }
}