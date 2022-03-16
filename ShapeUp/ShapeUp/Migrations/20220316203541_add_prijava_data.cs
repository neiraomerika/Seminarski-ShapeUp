using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShapeUp.Migrations
{
    public partial class add_prijava_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Prijava",
                columns: new[] { "Id", "Datum", "KlijentId" },
                values: new object[] { 1, new DateTime(2022, 3, 16, 21, 35, 41, 57, DateTimeKind.Local).AddTicks(6461), "7ed7b7ac-1ca0-4a8c-a6a8-43e786872cf8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prijava",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
