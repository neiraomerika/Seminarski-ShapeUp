using Microsoft.EntityFrameworkCore.Migrations;

namespace ShapeUp.Migrations
{
    public partial class added_prop_to_mentorstva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NazivKlijenta",
                table: "Mentorstvo",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NazivKlijenta",
                table: "Mentorstvo");
        }
    }
}
