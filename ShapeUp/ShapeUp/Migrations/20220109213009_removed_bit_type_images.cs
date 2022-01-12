using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShapeUp.Migrations
{
    public partial class removed_bit_type_images : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slika",
                table: "Trening");

            migrationBuilder.DropColumn(
                name: "Slika",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "Slika",
                table: "PlanPrehrane");

            migrationBuilder.RenameColumn("Slikab", "Trening", "Slika");
            migrationBuilder.RenameColumn("Slikab", "Proizvod", "Slika");
            migrationBuilder.RenameColumn("Slikab", "PlanPrehrane", "Slika");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn("Slika", "Trening", "Slikab");
            migrationBuilder.RenameColumn("Slika", "Proizvod", "Slikab");
            migrationBuilder.RenameColumn("Slika", "PlanPrehrane", "Slikab");

            migrationBuilder.AddColumn<byte[]>(
                name: "Slika",
                table: "Trening",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Slika",
                table: "Proizvod",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Slika",
                table: "PlanPrehrane",
                type: "varbinary(max)",
                nullable: true);            
        }
    }
}
