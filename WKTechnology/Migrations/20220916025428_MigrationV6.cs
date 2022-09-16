using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WKTechnology.Migrations
{
    public partial class MigrationV6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Products_Category_IdCategory",
            //    table: "Products");

            //migrationBuilder.RenameColumn(
            //    name: "IdCategory",
            //    table: "Category",
            //    newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "IdCategory",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category_IdCategory",
                table: "Products",
                column: "IdCategory",
                principalTable: "Category",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Category_IdCategory",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Category",
                newName: "IdCategory");

            migrationBuilder.AlterColumn<int>(
                name: "IdCategory",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category_IdCategory",
                table: "Products",
                column: "IdCategory",
                principalTable: "Category",
                principalColumn: "IdCategory",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
