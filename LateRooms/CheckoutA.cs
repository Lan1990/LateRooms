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
            if (items.Count ==3 )
            {
                return 130;
            }
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