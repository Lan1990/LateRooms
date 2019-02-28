namespace LateRooms
{
    public interface IStockKeepItem
    {
        int Price { get; }

        int NumberOfItemForDiscount { get; }
        int DiscountPrice { get; }
    }
}