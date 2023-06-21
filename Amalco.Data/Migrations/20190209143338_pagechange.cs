using Microsoft.EntityFrameworkCore.Migrations;

namespace Amalco.Data.Migrations
{
    public partial class pagechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content2",
                table: "Pages",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content2",
                table: "Pages");
        }
    }
}
