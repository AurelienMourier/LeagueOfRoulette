using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueOfRouletteAPI.Migrations
{
    public partial class fixuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Backpack_BackpackId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BackpackId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BackpackId",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BackpackId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BackpackId",
                table: "AspNetUsers",
                column: "BackpackId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Backpack_BackpackId",
                table: "AspNetUsers",
                column: "BackpackId",
                principalTable: "Backpack",
                principalColumn: "BackpackId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
