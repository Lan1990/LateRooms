using System;
using System.Collections.Generic;
using System.Text;

namespace LateRooms
{
    public class CheckoutB : ICheckout<StockKeepItemB>
    {
        List<StockKeepItemB> items;

        public CheckoutB()
        {
            items = new List<StockKeepItemB>();
        }
        public int GetTotalPrice()
        {
            
            int total = 0;
            items.ForEach(x => total += x.Price);


            return total;
        }

        public void Scan(StockKeepItemB item)
        {
            items.Add(item);
        }
    }
}
