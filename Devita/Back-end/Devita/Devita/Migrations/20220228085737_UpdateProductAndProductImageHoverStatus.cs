using Microsoft.EntityFrameworkCore.Migrations;

namespace Devita.Migrations
{
    public partial class UpdateProductAndProductImageHoverStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HoverStatus",
                table: "ProductImages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HoverStatus",
                table: "ProductImages",
                type: "bit",
                nullable: true);
        }
    }
}
