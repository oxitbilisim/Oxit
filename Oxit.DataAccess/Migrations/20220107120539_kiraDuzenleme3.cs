using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oxit.DataAccess.Migrations
{
    public partial class kiraDuzenleme3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsletmeKDV",
                table: "Kira");

            migrationBuilder.DropColumn(
                name: "KiraKDV",
                table: "Kira");

            migrationBuilder.RenameColumn(
                name: "ToplamKiraVeIsletme",
                table: "Kira",
                newName: "KiraVeIsletmeKDVSizToplam");

            migrationBuilder.RenameColumn(
                name: "ToplamKira",
                table: "Kira",
                newName: "KiraKDVToplam");

            migrationBuilder.RenameColumn(
                name: "ToplamIsletme",
                table: "Kira",
                newName: "IsletmeKDVToplam");

            migrationBuilder.AddColumn<string>(
                name: "Acıklama",
                table: "Kira",
                type: "text",
                nullable: false,
                defaultValue: "")
                .Annotation("Npgsql:DefaultColumnCollation", "turkish_collection");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Acıklama",
                table: "Kira");

            migrationBuilder.RenameColumn(
                name: "KiraVeIsletmeKDVSizToplam",
                table: "Kira",
                newName: "ToplamKiraVeIsletme");

            migrationBuilder.RenameColumn(
                name: "KiraKDVToplam",
                table: "Kira",
                newName: "ToplamKira");

            migrationBuilder.RenameColumn(
                name: "IsletmeKDVToplam",
                table: "Kira",
                newName: "ToplamIsletme");

            migrationBuilder.AddColumn<double>(
                name: "IsletmeKDV",
                table: "Kira",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "KiraKDV",
                table: "Kira",
                type: "double precision",
                nullable: true);
        }
    }
}
