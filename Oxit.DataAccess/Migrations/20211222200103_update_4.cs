using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oxit.DataAccess.Migrations
{
    public partial class update_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ZamanindaOdemeTarihi",
                table: "Fis",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ZamanindaOdenenTutar",
                table: "Fis",
                type: "double precision",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ZamanindaOdemeTarihi",
                table: "Fis");

            migrationBuilder.DropColumn(
                name: "ZamanindaOdenenTutar",
                table: "Fis");
        }
    }
}
