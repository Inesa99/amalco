using Microsoft.EntityFrameworkCore.Migrations;

namespace Amalco.Data.Migrations
{
    public partial class Changes2Service : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OrderBannerImage",
                table: "Services",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PriceTitle",
                table: "Services",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResponsibilityTitle",
                table: "Services",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderBannerImage",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "PriceTitle",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "ResponsibilityTitle",
                table: "Services");
        }
    }
}
