using System;
using Microsoft.EntityFrameworkCore.Migrations;
using ShapeUp.Database;
using ShapeUp.Database.Models;

namespace ShapeUp.Migrations
{
    public partial class add_rest_of_the_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8c12529b-2522-41d0-9e41-81765011d8d7", 0, false, "af0a9c1b-48b0-48db-a712-84e508489939", "admin@admin.com", false, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", null, "123-123-123", false, null, "42e828d3-72fc-4913-abff-743dd43fbd6b", false, "admin@admin.com" },
                    { "7ed7b7ac-1ca0-4a8c-a6a8-43e786872cf8", 1, false, "68522e8b-ee35-4624-8eae-59f62066a9f3", "test@test.com", false, "Test", "Test", false, null, "TEST@TEST.COM", "TEST@TEST.COM", null, "123-123-123", false, null, "6f70a850-3dbd-4394-97c0-7d0366f86b5e", false, "test@test.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "8c12529b-2522-41d0-9e41-81765011d8d7", "ebd8d330-d576-4f9b-a0cf-a758edc0c3c7" },
                    { "7ed7b7ac-1ca0-4a8c-a6a8-43e786872cf8", "b2870dbf-8690-4ba1-a52a-6714ef8c0fb6" }
                });

            migrationBuilder.InsertData(
                table: "Proizvod",
                columns: new[] { "Id", "Cijena", "KategorijaProizvodaId", "Naziv", "Opis", "ProsjecnaOcjena", "Slika" },
                values: new object[,]
                {
                    { 1, 98m, 2, "Gold Whey", "25g proteina u jednoj mjerici ovog nevjerovatnog proteina", 5m, null },
                    { 2, 20m, 9, "Vitamin C", "1000mg vitamina c", 5m, null }
                });

            migrationBuilder.InsertData(
                table: "Uplata",
                columns: new[] { "Id", "ChargeId", "Datum", "Iznos", "Placeno" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 3, 16, 21, 23, 33, 780, DateTimeKind.Local).AddTicks(7632), 200m, false },
                    { 2, null, new DateTime(2022, 3, 16, 21, 23, 33, 787, DateTimeKind.Local).AddTicks(105), 250m, false }
                });

            migrationBuilder.InsertData(
                table: "KlijentProizvodOcjena",
                columns: new[] { "Id", "KlijentId", "Ocjena", "ProizvodId" },
                values: new object[,]
                {
                    { 1, "7ed7b7ac-1ca0-4a8c-a6a8-43e786872cf8", 5m, 1 },
                    { 2, "7ed7b7ac-1ca0-4a8c-a6a8-43e786872cf8", 5m, 2 }
                });

            migrationBuilder.InsertData(
                table: "Mentorstvo",
                columns: new[] { "Id", "DatumPocetka", "DatumZavrsetka", "NazivKlijenta", "UplataId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Test", 1 },
                    { 2, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Test", 2 }
                });

            migrationBuilder.InsertData(
                table: "Plan",
                columns: new[] { "Id", "Datum", "KlijentId", "MentorstvoId", "PlanPrehraneId", "TreningId" },
                values: new object[] { 1, new DateTime(2022, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "7ed7b7ac-1ca0-4a8c-a6a8-43e786872cf8", 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Plan",
                columns: new[] { "Id", "Datum", "KlijentId", "MentorstvoId", "PlanPrehraneId", "TreningId" },
                values: new object[] { 2, new DateTime(2022, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "7ed7b7ac-1ca0-4a8c-a6a8-43e786872cf8", 1, 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ed7b7ac-1ca0-4a8c-a6a8-43e786872cf8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c12529b-2522-41d0-9e41-81765011d8d7");

            migrationBuilder.DeleteData(
                table: "KlijentProizvodOcjena",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "KlijentProizvodOcjena",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mentorstvo",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mentorstvo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Proizvod",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Proizvod",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Uplata",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Uplata",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
