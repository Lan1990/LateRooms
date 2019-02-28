using System;
using System.Collections.Generic;

namespace LateRooms
{
    public class FinalCheckout
    {
        Checkout<StockKeepItemA> checkoutA = new Checkout<StockKeepItemA>();
        Checkout<StockKeepItemB> checkoutB = new Checkout<StockKeepItemB>();

  

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