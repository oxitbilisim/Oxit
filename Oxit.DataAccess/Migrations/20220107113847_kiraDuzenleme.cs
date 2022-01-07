using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oxit.DataAccess.Migrations
{
    public partial class kiraDuzenleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ToplamFiyat",
                table: "Kira",
                newName: "ToplamKiraVeIsletmeKDVli");

            migrationBuilder.AddColumn<double>(
                name: "IsletmeBedeli",
                table: "Kira",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "IsletmeKDV",
                table: "Kira",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "KiraBedeli",
                table: "Kira",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "KiraKDV",
                table: "Kira",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MetrekareIsletmeFiyati",
                table: "Kira",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ToplamIsletme",
                table: "Kira",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ToplamKira",
                table: "Kira",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ToplamKiraVeIsletme",
                table: "Kira",
                type: "double precision",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsletmeBedeli",
                table: "Kira");

            migrationBuilder.DropColumn(
                name: "IsletmeKDV",
                table: "Kira");

            migrationBuilder.DropColumn(
                name: "KiraBedeli",
                table: "Kira");

            migrationBuilder.DropColumn(
                name: "KiraKDV",
                table: "Kira");

            migrationBuilder.DropColumn(
                name: "MetrekareIsletmeFiyati",
                table: "Kira");

            migrationBuilder.DropColumn(
                name: "ToplamIsletme",
                table: "Kira");

            migrationBuilder.DropColumn(
                name: "ToplamKira",
                table: "Kira");

            migrationBuilder.DropColumn(
                name: "ToplamKiraVeIsletme",
                table: "Kira");

            migrationBuilder.RenameColumn(
                name: "ToplamKiraVeIsletmeKDVli",
                table: "Kira",
                newName: "ToplamFiyat");
        }
    }
}
