using Microsoft.EntityFrameworkCore.Migrations;

namespace ShapeUp.Migrations
{
    public partial class trening_planprehrane_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "KategorijaTreninga",
                columns: new[] { "Id", "Naziv" },
                values: new object[] { 5, "Ledja" });

            migrationBuilder.InsertData(
                table: "PlanPrehrane",
                columns: new[] { "Id", "CiljId", "NutritivneVrijednosti", "Opis", "Slika" },
                values: new object[,]
                {
                    { 1, 2, "1. Obrok: 30g prot, \n2. Obrok: 40g prot\n3. Obrok: 25g prot\n", "1. Obrok: 5 jaja\n2. Obrok: Leso meso i kuhani krompir\n3. Corn Flakes se whey proteinom", null },
                    { 2, 1, "1. Obrok: 12g prot, \n2. Obrok: 25g prot\n3. Obrok: 0g prot\n", "1. Obrok: 2 jaja\n2. Obrok: Pileca salata\n3. Casa vode", null }
                });

            migrationBuilder.InsertData(
                table: "Trening",
                columns: new[] { "Id", "CiljId", "KategorijaTreningaId", "Opis", "Slika", "VideoUrl" },
                values: new object[] { 2, 2, 4, "1. Biceps Z-Curl: 4x10\n   Triceps Cable Extension: 4x10\n2. Biceps Curls: 3x12\n   Single-Arm Cable Triceps Extension: 3x12\n3. Biceps Hammer Curls: 4x10\n   Dips 4x10", null, "https://www.youtube.com/c/SmaykiFitness" });

            migrationBuilder.InsertData(
                table: "Trening",
                columns: new[] { "Id", "CiljId", "KategorijaTreningaId", "Opis", "Slika", "VideoUrl" },
                values: new object[] { 1, 2, 5, "1. Pull-Ups: 4x10\n2. Bent-Over Row: 4x10\n3. Lat Pull-Down: 5x8\n4. Single-Arm Smith Machine Row: 3x12\n5. Deadlift: 5x5\n", null, "https://www.youtube.com/c/SmaykiFitness" });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlanPrehrane",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PlanPrehrane",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trening",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trening",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "KategorijaTreninga",
                keyColumn: "Id",
                keyValue: 5);

        }
    }
}
