namespace LateRooms
{
    public class StockKeepItemB : IStockKeepItem
    {

        public int Price => 30;

        public int NumberOfItemForDiscount => 2;

        public int DiscountPrice => 15;
    }
}