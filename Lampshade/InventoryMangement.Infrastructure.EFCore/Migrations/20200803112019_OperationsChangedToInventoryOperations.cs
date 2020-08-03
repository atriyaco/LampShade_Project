using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryMangement.Infrastructure.EFCore.Migrations
{
    public partial class OperationsChangedToInventoryOperations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Operations_Inventory_InventoryId",
                table: "Operations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Operations",
                table: "Operations");

            migrationBuilder.RenameTable(
                name: "Operations",
                newName: "InventoryOperations");

            migrationBuilder.RenameIndex(
                name: "IX_Operations_InventoryId",
                table: "InventoryOperations",
                newName: "IX_InventoryOperations_InventoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InventoryOperations",
                table: "InventoryOperations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryOperations_Inventory_InventoryId",
                table: "InventoryOperations",
                column: "InventoryId",
                principalTable: "Inventory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryOperations_Inventory_InventoryId",
                table: "InventoryOperations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InventoryOperations",
                table: "InventoryOperations");

            migrationBuilder.RenameTable(
                name: "InventoryOperations",
                newName: "Operations");

            migrationBuilder.RenameIndex(
                name: "IX_InventoryOperations_InventoryId",
                table: "Operations",
                newName: "IX_Operations_InventoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Operations",
                table: "Operations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Operations_Inventory_InventoryId",
                table: "Operations",
                column: "InventoryId",
                principalTable: "Inventory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
