using System.Collections.Generic;

namespace LateRooms
{
    internal class CheckoutA : ICheckout<StockKeepItemA>   
    {
        private List<StockKeepItemA> _items;
        public CheckoutA()
        {
            _items = new List<StockKeepItemA>();
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

        public void Scan(StockKeepItemA stockKeepItem)
        {
            _items.Add((StockKeepItemA)stockKeepItem);
        }
    }
}