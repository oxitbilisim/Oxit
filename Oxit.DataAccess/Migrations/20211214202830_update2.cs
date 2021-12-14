using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oxit.DataAccess.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DbId",
                table: "Cari",
                newName: "DbKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DbKey",
                table: "Cari",
                newName: "DbId");
        }
    }
}
