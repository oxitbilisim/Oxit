using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oxit.DataAccess.Migrations
{
    public partial class kiraDuzenleme2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MetrekareFiyati",
                table: "Kira",
                newName: "MetrekareKiraFiyati");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MetrekareKiraFiyati",
                table: "Kira",
                newName: "MetrekareFiyati");
        }
    }
}
