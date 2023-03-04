using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CateringOrders.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 1, "EMP", "6124d63e-1f0b-4866-8a03-530d52a73e65", "Employee", null });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 2, "COOK", "2352120d-7a4c-46cb-bf48-6d7853a6f6b8", "COOKER", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
