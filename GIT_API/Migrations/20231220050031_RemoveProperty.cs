using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GIT_API.Migrations
{
    public partial class RemoveProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Registers");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Registers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Registers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Registers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Registers");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Registers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
