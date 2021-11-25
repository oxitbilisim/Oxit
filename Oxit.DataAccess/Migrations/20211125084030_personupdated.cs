using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oxit.DataAccess.Migrations
{
    public partial class personupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Person");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Person",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Person",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NationalId",
                table: "Person",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Person",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "NationalId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Person");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Person",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Person",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Person",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
