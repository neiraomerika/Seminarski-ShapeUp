using Microsoft.EntityFrameworkCore.Migrations;

namespace ShapeUp.Migrations
{
    public partial class added_id_to_klijent_proizvod_ocjena : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "KlijentProizvodOcjena");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "KlijentProizvodOcjena",
                type: "int",
                nullable: false)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KlijentProizvodOcjena",
                table: "KlijentProizvodOcjena",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_KlijentProizvodOcjena",
                table: "KlijentProizvodOcjena");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "KlijentProizvodOcjena");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "KlijentProizvodOcjena",
                type: "int",
                nullable: false);
        }
    }
}
