using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortlandLocalShopsApi.Migrations
{
    public partial class addMusicType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MusicType",
                table: "Shops",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MusicType",
                table: "Shops");
        }
    }
}
