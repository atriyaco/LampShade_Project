namespace _01_LampshadeQuery.Contracts.Inventory
{
    public interface IInventoryQuery
    {
        StockStatus CheckStock(IsInStock command);
    }
}
