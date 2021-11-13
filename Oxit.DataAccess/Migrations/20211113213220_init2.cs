using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oxit.DataAccess.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Active", "CreateDate", "CreatorId", "DeleteDate", "EditDate", "EditorId", "IsDeleted", "Name" },
                values: new object[] { new Guid("c569ade6-116f-4e63-be5c-b38009299857"), true, null, null, null, null, null, false, "Ali" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: new Guid("c569ade6-116f-4e63-be5c-b38009299857"));
        }
    }
}
