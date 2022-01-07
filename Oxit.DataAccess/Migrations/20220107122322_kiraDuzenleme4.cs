using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oxit.DataAccess.Migrations
{
    public partial class kiraDuzenleme4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ToplamKiraVeIsletmeKDVli",
                table: "Kira",
                newName: "KiraVeIsletmeKDVliToplam");

            migrationBuilder.RenameColumn(
                name: "Acıklama",
                table: "Kira",
                newName: "Aciklama");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KiraVeIsletmeKDVliToplam",
                table: "Kira",
                newName: "ToplamKiraVeIsletmeKDVli");

            migrationBuilder.RenameColumn(
                name: "Aciklama",
                table: "Kira",
                newName: "Acıklama");
        }
    }
}
