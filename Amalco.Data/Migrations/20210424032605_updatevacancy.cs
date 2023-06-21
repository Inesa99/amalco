using Microsoft.EntityFrameworkCore.Migrations;

namespace Amalco.Data.Migrations
{
    public partial class updatevacancy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "ServicePayType",
                table: "Vacancies",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServicePayType",
                table: "Vacancies");
        }
    }
}
