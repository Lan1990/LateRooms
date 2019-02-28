namespace LateRooms
{
    public class StockKeepItemA : IStockKeepItem
    {


        public int Price => 50;

        public int NumberOfItemForDiscount => 3;

        public int DiscountPrice => 20;
    }
}