using System;
using System.Collections.Generic;

namespace LateRooms
{
    public class Checkout
    {
        private List<StockKeepItem> _items;

        public Checkout()
        {
            _items = new List<StockKeepItem>();
        }

        public void Scan(StockKeepItem stockKeepItem)
        {
            _items.Add(stockKeepItem);
        }

        public int GetTotalPrice()
        {

            int total = 0;
            foreach (var item in _items)
            {
                total += item.Price;
            }
            return total;
        }
    }
}