namespace InventoryManagement.Application.Contract.Inventory
{
    public class IncreaseInventory
    {
        public long InventoryId { get; set; }
        public long Count { get; set; }
        public string Description { get; set; }
    }
}
