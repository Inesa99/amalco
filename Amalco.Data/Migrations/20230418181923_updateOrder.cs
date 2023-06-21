using Microsoft.EntityFrameworkCore.Migrations;

namespace Amalco.Data.Migrations
{
    public partial class updateOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Vacancies_VacancyId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_VacancyId",
                table: "Orders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Orders_VacancyId",
                table: "Orders",
                column: "VacancyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Vacancies_VacancyId",
                table: "Orders",
                column: "VacancyId",
                principalTable: "Vacancies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
