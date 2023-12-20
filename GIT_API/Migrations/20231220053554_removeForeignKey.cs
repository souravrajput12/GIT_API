using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GIT_API.Migrations
{
    public partial class removeForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registers_UserLogins_UserLoginId",
                table: "Registers");

            migrationBuilder.DropIndex(
                name: "IX_Registers_UserLoginId",
                table: "Registers");

            migrationBuilder.DropColumn(
                name: "UserLoginId",
                table: "Registers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserLoginId",
                table: "Registers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Registers_UserLoginId",
                table: "Registers",
                column: "UserLoginId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registers_UserLogins_UserLoginId",
                table: "Registers",
                column: "UserLoginId",
                principalTable: "UserLogins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
