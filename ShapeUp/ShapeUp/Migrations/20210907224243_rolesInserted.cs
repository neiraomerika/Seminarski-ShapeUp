using Microsoft.EntityFrameworkCore.Migrations;

namespace ShapeUp.Migrations
{
    public partial class rolesInserted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4ae1cd53-6fa3-44fd-9aa2-65eaf1ad1d89", "3eabdb8d-ad90-4a2c-af3a-6cc22d48fbbf", "Klijent", "KLIJENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8aab5189-73e0-4604-a00f-ae63d79bae4a", "29b51054-96d6-49e9-a396-5369cfb2b14b", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ae1cd53-6fa3-44fd-9aa2-65eaf1ad1d89");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8aab5189-73e0-4604-a00f-ae63d79bae4a");
        }
    }
}
