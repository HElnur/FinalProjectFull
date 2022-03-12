using Microsoft.EntityFrameworkCore.Migrations;

namespace Devita.Migrations
{
    public partial class UpdateOrderTableAppUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_AppUserId1",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_AppUserId1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "AppUserId1",
                table: "Order");

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "Order",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Order_AppUserId",
                table: "Order",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_AppUserId",
                table: "Order",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_AppUserId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_AppUserId",
                table: "Order");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "Order",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId1",
                table: "Order",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_AppUserId1",
                table: "Order",
                column: "AppUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_AppUserId1",
                table: "Order",
                column: "AppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
