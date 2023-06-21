using Microsoft.EntityFrameworkCore.Migrations;

namespace Amalco.Data.Migrations
{
    public partial class addsalaryrange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SalaryDo",
                table: "Vacancies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SalaryDo",
                table: "Vacancies");
        }
    }
}
