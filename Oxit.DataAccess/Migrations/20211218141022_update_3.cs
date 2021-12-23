using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oxit.DataAccess.Migrations
{
    public partial class update_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "GecikmeTutari",
                table: "Fis",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SonHesaplananGecikmeTarihi",
                table: "Fis",
                type: "timestamp without time zone",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GecikmeTutari",
                table: "Fis");

            migrationBuilder.DropColumn(
                name: "SonHesaplananGecikmeTarihi",
                table: "Fis");
        }
    }
}
