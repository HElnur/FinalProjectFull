using Microsoft.EntityFrameworkCore.Migrations;

namespace Devita.Migrations
{
    public partial class UpdateProductCommentAddCommentStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CommentStatus",
                table: "ProductComments",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentStatus",
                table: "ProductComments");
        }
    }
}
