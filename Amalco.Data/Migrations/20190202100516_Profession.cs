using Microsoft.EntityFrameworkCore.Migrations;

namespace Amalco.Data.Migrations
{
    public partial class Profession : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Profession",
                table: "Reviews",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Profession",
                table: "Reviews");
        }
    }
}
