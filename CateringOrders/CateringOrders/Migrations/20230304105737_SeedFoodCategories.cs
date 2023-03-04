using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CateringOrders.Migrations
{
    public partial class SeedFoodCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FoodCategory",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Salads" },
                    { 2, "Main Plate" },
                    { 3, "Dessert" },
                    { 4, "Fruits" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FoodCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FoodCategory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FoodCategory",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
