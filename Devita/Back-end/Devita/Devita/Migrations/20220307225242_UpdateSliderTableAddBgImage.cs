using Microsoft.EntityFrameworkCore.Migrations;

namespace Devita.Migrations
{
    public partial class UpdateSliderTableAddBgImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BgImage",
                table: "Sliders",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BgImage",
                table: "Sliders");
        }
    }
}
