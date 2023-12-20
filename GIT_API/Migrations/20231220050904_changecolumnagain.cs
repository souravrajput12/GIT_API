using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GIT_API.Migrations
{
    public partial class changecolumnagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registers_UserLogins_UserIdId",
                table: "Registers");

            migrationBuilder.RenameColumn(
                name: "UserIdId",
                table: "Registers",
                newName: "UserLoginId");

            migrationBuilder.RenameIndex(
                name: "IX_Registers_UserIdId",
                table: "Registers",
                newName: "IX_Registers_UserLoginId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registers_UserLogins_UserLoginId",
                table: "Registers",
                column: "UserLoginId",
                principalTable: "UserLogins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registers_UserLogins_UserLoginId",
                table: "Registers");

            migrationBuilder.RenameColumn(
                name: "UserLoginId",
                table: "Registers",
                newName: "UserIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Registers_UserLoginId",
                table: "Registers",
                newName: "IX_Registers_UserIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registers_UserLogins_UserIdId",
                table: "Registers",
                column: "UserIdId",
                principalTable: "UserLogins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
