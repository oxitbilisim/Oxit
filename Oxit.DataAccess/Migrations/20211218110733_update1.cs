using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oxit.DataAccess.Migrations
{
    public partial class update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Tarih",
                table: "Fis",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<string>(
                name: "FisTur",
                table: "Fis",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true)
                .Annotation("Npgsql:DefaultColumnCollation", "turkish_collection");

            migrationBuilder.AlterColumn<string>(
                name: "FisNo",
                table: "Fis",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true)
                .Annotation("Npgsql:DefaultColumnCollation", "turkish_collection");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Tarih",
                table: "Fis",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FisTur",
                table: "Fis",
                type: "integer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text")
                .OldAnnotation("Npgsql:DefaultColumnCollation", "turkish_collection");

            migrationBuilder.AlterColumn<int>(
                name: "FisNo",
                table: "Fis",
                type: "integer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text")
                .OldAnnotation("Npgsql:DefaultColumnCollation", "turkish_collection");
        }
    }
}
