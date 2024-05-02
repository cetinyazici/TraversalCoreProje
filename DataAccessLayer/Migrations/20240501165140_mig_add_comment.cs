using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_comment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Comments_DestinationId",
                table: "Comments");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_DestinationId",
                table: "Comments",
                column: "DestinationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Comments_DestinationId",
                table: "Comments");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_DestinationId",
                table: "Comments",
                column: "DestinationId",
                unique: true);
        }
    }
}
