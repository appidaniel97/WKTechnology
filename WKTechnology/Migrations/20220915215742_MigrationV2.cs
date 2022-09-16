using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WKTechnology.Migrations
{
    public partial class MigrationV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ncm",
                table: "Products",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<decimal>(
                name: "PriceCost",
                table: "Products",
                type: "decimal(65,30)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ncm",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PriceCost",
                table: "Products");
        }
    }
}
