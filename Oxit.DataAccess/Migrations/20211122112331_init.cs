﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oxit.DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Active", "CreateDate", "CreatorId", "DeleteDate", "EditDate", "EditorId", "IsDeleted", "Name" },
                values: new object[] { new Guid("c569ade6-116f-4e63-be5c-b38009299857"), true, null, null, null, null, null, false, "Ali" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}