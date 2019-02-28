using System.Collections.Generic;

namespace LateRooms
{
    public class CheckoutA : ICheckout<StockKeepItemA>
    {

        List<StockKeepItemA> items;

        public CheckoutA()
        {
            items = new List<StockKeepItemA>();
        }
        public int GetTotalPrice()
        {
            int total =0;
            items.ForEach(x => total += x.Price);
            return total;
        }

        public void Scan(StockKeepItemA item)
        {
            items.Add(item);
        }
    }
}