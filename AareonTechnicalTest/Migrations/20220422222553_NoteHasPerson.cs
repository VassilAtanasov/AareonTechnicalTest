using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AareonTechnicalTest.Migrations
{
    public partial class NoteHasPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Notes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Notes");
        }
    }
}
