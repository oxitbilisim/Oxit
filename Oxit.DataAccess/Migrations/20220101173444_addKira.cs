using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Oxit.DataAccess.Migrations
{
    public partial class addKira : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kira",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirmaAdi = table.Column<string>(type: "text", nullable: true)
                        .Annotation("Npgsql:DefaultColumnCollation", "turkish_collection"),
                    BaslamaTarihi = table.Column<DateOnly>(type: "date", nullable: true),
                    BitisTarihi = table.Column<DateOnly>(type: "date", nullable: true),
                    Metrekare = table.Column<double>(type: "double precision", nullable: true),
                    MetrekareFiyati = table.Column<double>(type: "double precision", nullable: true),
                    ToplamFiyat = table.Column<double>(type: "double precision", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kira", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kira");
        }
    }
}
