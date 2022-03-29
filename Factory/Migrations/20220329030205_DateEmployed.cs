using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class DateEmployed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Engineers",
                newName: "DateEmployed");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateEmployed",
                table: "Engineers",
                newName: "DateTime");
        }
    }
}
