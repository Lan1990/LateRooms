using System.Collections.Generic;

namespace LateRooms
{
    public class CheckoutA : ICheckout<StockKeepItemA>
    {

        List<StockKeepItemA> items;

        private int _numberOfItemForDiscount = 3;
        private int _discountPrice = 20;

        public CheckoutA()
        {
            items = new List<StockKeepItemA>();
        }
        public int GetTotalPrice()
        {
            
            int total =0;
            items.ForEach(x => total += x.Price);

            var div = items.Count / _numberOfItemForDiscount * _discountPrice;
            total -= div;
            return total;
        }

        public void Scan(StockKeepItemA item)
        {
            items.Add(item);
        }
    }
}