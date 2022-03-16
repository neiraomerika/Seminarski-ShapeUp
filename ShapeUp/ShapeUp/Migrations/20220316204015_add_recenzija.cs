using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShapeUp.Migrations
{
    public partial class add_recenzija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Recenzija",
                columns: new[] { "Id", "Datum", "MentorstvoId", "Ocjena", "Opis" },
                values: new object[] { 1, new DateTime(2022, 3, 16, 21, 40, 15, 42, DateTimeKind.Local).AddTicks(3677), 1, 4, "Vrlo dobro odradjen mjesec, u slijedecem idemo jos jace." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
