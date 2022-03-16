using Microsoft.EntityFrameworkCore.Migrations;

namespace Devita.Migrations
{
    public partial class AddColorProductToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductColor_Colors_ColorId",
                table: "ProductColor");

            migrationBuilder.DropIndex(
                name: "IX_ProductColor_ColorId",
                table: "ProductColor");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "ProductColor");

            migrationBuilder.AddColumn<int>(
                name: "Color",
                table: "ProductColor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductColorId",
                table: "Colors",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Colors_ProductColorId",
                table: "Colors",
                column: "ProductColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Colors_ProductColor_ProductColorId",
                table: "Colors",
                column: "ProductColorId",
                principalTable: "ProductColor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colors_ProductColor_ProductColorId",
                table: "Colors");

            migrationBuilder.DropIndex(
                name: "IX_Colors_ProductColorId",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "ProductColor");

            migrationBuilder.DropColumn(
                name: "ProductColorId",
                table: "Colors");

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "ProductColor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductColor_ColorId",
                table: "ProductColor",
                column: "ColorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColor_Colors_ColorId",
                table: "ProductColor",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
