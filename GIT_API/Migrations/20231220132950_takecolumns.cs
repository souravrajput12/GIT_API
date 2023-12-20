using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GIT_API.Migrations
{
    public partial class takecolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Employee_Name",
                table: "Registers",
                newName: "UserName");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Registers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Registers");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Registers",
                newName: "Employee_Name");
        }
    }
}
