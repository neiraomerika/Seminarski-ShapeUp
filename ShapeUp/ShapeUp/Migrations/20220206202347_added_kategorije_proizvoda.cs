using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShapeUp.Migrations
{
    public partial class added_kategorije_proizvoda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "KategorijaProizvoda",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 1, "amino kiseline" },
                    { 2, "protein" },
                    { 3, "energetska pica" },
                    { 4, "gejneri" },
                    { 5, "gubljenje kilograma" },
                    { 6, "kreatin" },
                    { 7, "pre-workout" },
                    { 8, "hormonski pojacivaci" },
                    { 9, "vitamini & minerali" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Proizvod_Kategorija_FK",
                table: "Proizvod");

            migrationBuilder.DeleteData(
                table: "KategorijaProizvoda",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "KategorijaProizvoda",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "KategorijaProizvoda",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "KategorijaProizvoda",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "KategorijaProizvoda",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "KategorijaProizvoda",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "KategorijaProizvoda",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "KategorijaProizvoda",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "KategorijaProizvoda",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
