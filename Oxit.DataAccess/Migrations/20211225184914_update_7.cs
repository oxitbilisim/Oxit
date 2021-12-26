using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oxit.DataAccess.Migrations
{
    public partial class update_7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "GeciktirilenAnaFaizTutar",
                table: "Fis",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "GeciktirilenTutar",
                table: "Fis",
                type: "double precision",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GeciktirilenAnaFaizTutar",
                table: "Fis");

            migrationBuilder.DropColumn(
                name: "GeciktirilenTutar",
                table: "Fis");
        }
    }
}
