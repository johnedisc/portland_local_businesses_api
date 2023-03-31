using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortlandLocalShopsApi.Migrations
{
    public partial class fixSytaxIssues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "MusicType", "Name", "PartOfTown", "StoreType" },
                values: new object[,]
                {
                    { 1, "various, singer-songwriter, guitar-bass-drums", "doug fir lounge", "e, east", "music venue" },
                    { 2, "various, salsa, timba, singer-songwriter, guitar-bass-drums", "mississippi pizza", "ne, northeast", "pizza restaurant, music venue" },
                    { 3, "various, funk, salsa, guitar-bass-drums", "the goodfoot", "ne, northeast", "bar, music venue" },
                    { 4, "jazz", "the 1905", "ne, northeast", "bar, pizza, music venue" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 4);
        }
    }
}
