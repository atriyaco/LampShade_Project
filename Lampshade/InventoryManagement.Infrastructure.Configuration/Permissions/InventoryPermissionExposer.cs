using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace InventoryManagement.Infrastructure.Configuration.Permissions
{
    public class InventoryPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Inventory", new List<PermissionDto>
                    {
                        new PermissionDto(50, "ListInventory"),
                        new PermissionDto(51, "SearchInventory"),
                        new PermissionDto(52, "CreateInventory"),
                        new PermissionDto(53, "EditInventory")
                    }
                }
            };
        }
    }
}