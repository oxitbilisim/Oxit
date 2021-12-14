using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oxit.DataAccess.Migrations
{
    public partial class update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DbId",
                table: "Cari",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:DefaultColumnCollation", "turkish_collection");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DbId",
                table: "Cari",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text")
                .OldAnnotation("Npgsql:DefaultColumnCollation", "turkish_collection");
        }
    }
}
