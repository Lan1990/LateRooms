using System;
using System.Collections.Generic;
using System.Text;

namespace LateRooms
{
    public class CheckoutB : ICheckout<StockKeepItemB>
    {
        private readonly int _numberOfItemForDiscount = 2;
        private readonly int _discountPrice = 15;
        List<StockKeepItemB> items;

        public CheckoutB()
        {
            items = new List<StockKeepItemB>();
        }
        public int GetTotalPrice()
        {

            int total = 0;
            items.ForEach(x => total += x.Price);

            var div = items.Count / _numberOfItemForDiscount * _discountPrice;
            total -= div;
            return total;
        }

        public void Scan(StockKeepItemB item)
        {
            items.Add(item);
        }
    }
}
