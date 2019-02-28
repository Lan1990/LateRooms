namespace LateRooms
{
    internal interface ICheckout<T> where T : StockKeepItem
    {
        void Scan(T stockKeepItem);

        int GetTotalPrice();
    }
}