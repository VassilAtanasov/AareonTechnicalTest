using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AareonTechnicalTest.Migrations
{
    public partial class APersonHasNotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Notes_PersonId",
                table: "Notes",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Persons_PersonId",
                table: "Notes",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Persons_PersonId",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Notes_PersonId",
                table: "Notes");
        }
    }
}
