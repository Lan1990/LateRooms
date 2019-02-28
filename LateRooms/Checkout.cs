using System;
using System.Collections.Generic;
using System.Linq;

namespace LateRooms
{
    public class Checkout
    {
        private List<ICheckout> _checkouts;

        public Checkout()
        {
            _checkouts = new List<ICheckout>();
        }

        public void Scan(StockKeepItem stockKeepItem)
        {
            if (stockKeepItem is StockKeepItemA )
            {
                var checkoutA = _checkouts.FirstOrDefault(x => x is CheckoutA);
                if (checkoutA == null)
                {
                    _checkouts.Add(new CheckoutA());
                }
                checkoutA.Scan(stockKeepItem);
            }
        }

        public int GetTotalPrice()
        {

            int total = 0;
            foreach (var checkout in _checkouts)
            {
                total += checkout.GetTotalPrice();
            }
            return total;
        }
    }
}