using System;
using System.Collections.Generic;

namespace LateRooms
{
    public class Checkout
    {
        private List<StockKeepItem> items;

        public Checkout()
        {
            items = new List<StockKeepItem>();
        }

        public void Scan(StockKeepItem stockKeepItem)
        {
            items.Add(stockKeepItem);
        }

        public int GetTotalPrice()
        {
            int total = 0;
            foreach (var item in items)
            {
                total += item.Price;
            }
            return total;
        }
    }
}