using Microsoft.EntityFrameworkCore.Migrations;

namespace ShapeUp.Migrations
{
    public partial class DodavanjeKategorijaTreninga_cilja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ae1cd53-6fa3-44fd-9aa2-65eaf1ad1d89");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8aab5189-73e0-4604-a00f-ae63d79bae4a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b2870dbf-8690-4ba1-a52a-6714ef8c0fb6", "c46b211a-e353-44e9-a131-b0a5fb089a9b", "Klijent", "KLIJENT" },
                    { "ebd8d330-d576-4f9b-a0cf-a758edc0c3c7", "55e66552-eebc-49cc-9203-8b80b1a2866e", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Cilj",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 1, "Mršavljenje" },
                    { 2, "Dobivanje mišične mase" }
                });

            migrationBuilder.InsertData(
                table: "KategorijaTreninga",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 1, "Noge" },
                    { 2, "Gluteus" },
                    { 3, "Stomak" },
                    { 4, "Ruke" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2870dbf-8690-4ba1-a52a-6714ef8c0fb6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebd8d330-d576-4f9b-a0cf-a758edc0c3c7");

            migrationBuilder.DeleteData(
                table: "Cilj",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cilj",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "KategorijaTreninga",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "KategorijaTreninga",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "KategorijaTreninga",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "KategorijaTreninga",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4ae1cd53-6fa3-44fd-9aa2-65eaf1ad1d89", "3eabdb8d-ad90-4a2c-af3a-6cc22d48fbbf", "Klijent", "KLIJENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8aab5189-73e0-4604-a00f-ae63d79bae4a", "29b51054-96d6-49e9-a396-5369cfb2b14b", "Administrator", "ADMINISTRATOR" });
        }
    }
}
