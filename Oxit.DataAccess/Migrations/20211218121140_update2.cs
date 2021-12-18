using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oxit.DataAccess.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FisTur",
                table: "Fis",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text")
                .Annotation("Npgsql:DefaultColumnCollation", "turkish_collection")
                .OldAnnotation("Npgsql:DefaultColumnCollation", "turkish_collection");

            migrationBuilder.AlterColumn<string>(
                name: "FisNo",
                table: "Fis",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text")
                .Annotation("Npgsql:DefaultColumnCollation", "turkish_collection")
                .OldAnnotation("Npgsql:DefaultColumnCollation", "turkish_collection");

            migrationBuilder.AlterColumn<string>(
                name: "DbKey",
                table: "Fis",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text")
                .Annotation("Npgsql:DefaultColumnCollation", "turkish_collection")
                .OldAnnotation("Npgsql:DefaultColumnCollation", "turkish_collection");

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "Fis",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text")
                .Annotation("Npgsql:DefaultColumnCollation", "turkish_collection")
                .OldAnnotation("Npgsql:DefaultColumnCollation", "turkish_collection");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FisTur",
                table: "Fis",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("Npgsql:DefaultColumnCollation", "turkish_collection")
                .OldAnnotation("Npgsql:DefaultColumnCollation", "turkish_collection");

            migrationBuilder.AlterColumn<string>(
                name: "FisNo",
                table: "Fis",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("Npgsql:DefaultColumnCollation", "turkish_collection")
                .OldAnnotation("Npgsql:DefaultColumnCollation", "turkish_collection");

            migrationBuilder.AlterColumn<string>(
                name: "DbKey",
                table: "Fis",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("Npgsql:DefaultColumnCollation", "turkish_collection")
                .OldAnnotation("Npgsql:DefaultColumnCollation", "turkish_collection");

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "Fis",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("Npgsql:DefaultColumnCollation", "turkish_collection")
                .OldAnnotation("Npgsql:DefaultColumnCollation", "turkish_collection");
        }
    }
}
