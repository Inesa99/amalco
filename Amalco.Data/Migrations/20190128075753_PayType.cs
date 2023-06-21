using Microsoft.EntityFrameworkCore.Migrations;

namespace Amalco.Data.Migrations
{
    public partial class PayType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "ServicePayType",
                table: "Services",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServicePayType",
                table: "Services");
        }
    }
}
