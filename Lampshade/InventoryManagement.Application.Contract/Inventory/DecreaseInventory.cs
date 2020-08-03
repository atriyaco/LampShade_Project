namespace InventoryManagement.Application.Contract.Inventory
{
    public class DecreaseInventory
    {
        public long ProductId { get; set; }
        public long Count { get; set; }
        public string Description { get; set; }
        public long OrderId { get; set; }
    }
}
