using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LateRooms
{
    public class Checkout<T> where T : IStockKeepItem
    {
        List<T> items;


        public Checkout()
        {
            items = new List<T>();
        }
        public int GetTotalPrice()
        {
            if (!items.Any())
            {
                return 0;
            }
            int total = 0;
            items.ForEach(x => total += x.Price);

            var div = items.Count / items[0].NumberOfItemForDiscount * items[0].DiscountPrice;
            total -= div;
            return total;
        }

        public void Scan(T item)
        {
            items.Add(item);
        }
    }
}
