using System;
using System.Collections.Generic;
using System.Text;

namespace LateRooms
{
    public interface ICheckout<T> where T : IStockKeepItem
    {
        void Scan(T item);

        int GetTotalPrice();
    }
}
