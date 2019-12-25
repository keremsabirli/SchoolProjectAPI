using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolProjectAPI.Migrations
{
    public partial class QuickFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TextWidget_Users_UserId",
                table: "TextWidget");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TextWidget",
                table: "TextWidget");

            migrationBuilder.RenameTable(
                name: "TextWidget",
                newName: "TextWidgets");

            migrationBuilder.RenameIndex(
                name: "IX_TextWidget_UserId",
                table: "TextWidgets",
                newName: "IX_TextWidgets_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TextWidgets",
                table: "TextWidgets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TextWidgets_Users_UserId",
                table: "TextWidgets",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TextWidgets_Users_UserId",
                table: "TextWidgets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TextWidgets",
                table: "TextWidgets");

            migrationBuilder.RenameTable(
                name: "TextWidgets",
                newName: "TextWidget");

            migrationBuilder.RenameIndex(
                name: "IX_TextWidgets_UserId",
                table: "TextWidget",
                newName: "IX_TextWidget_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TextWidget",
                table: "TextWidget",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TextWidget_Users_UserId",
                table: "TextWidget",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
