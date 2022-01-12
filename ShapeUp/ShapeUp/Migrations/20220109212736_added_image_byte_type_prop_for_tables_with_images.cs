using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShapeUp.Migrations
{
    public partial class added_image_byte_type_prop_for_tables_with_images : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Slikab",
                table: "Trening",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Slikab",
                table: "Proizvod",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Slikab",
                table: "PlanPrehrane",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slikab",
                table: "Trening");

            migrationBuilder.DropColumn(
                name: "Slikab",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "Slikab",
                table: "PlanPrehrane");
        }
    }
}
