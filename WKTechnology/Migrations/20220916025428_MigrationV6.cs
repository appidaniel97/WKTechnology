using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WKTechnology.Migrations
{
    public partial class MigrationV6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Products_Category_Categoria",
            //    table: "Products");

            //migrationBuilder.RenameColumn(
            //    name: "Categoria",
            //    table: "Category",
            //    newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "Categoria",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category_Categoria",
                table: "Products",
                column: "Categoria",
                principalTable: "Category",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Category_Categoria",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Category",
                newName: "Categoria");

            migrationBuilder.AlterColumn<int>(
                name: "Categoria",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category_Categoria",
                table: "Products",
                column: "Categoria",
                principalTable: "Category",
                principalColumn: "Categoria",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
