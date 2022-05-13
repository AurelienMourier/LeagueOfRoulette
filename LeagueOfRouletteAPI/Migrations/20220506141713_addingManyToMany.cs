using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueOfRouletteAPI.Migrations
{
    public partial class addingManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Card_Box_BoxId",
                table: "Card");

            migrationBuilder.DropIndex(
                name: "IX_Card_BoxId",
                table: "Card");

            migrationBuilder.DropColumn(
                name: "BoxId",
                table: "Card");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BoxId",
                table: "Card",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Card_BoxId",
                table: "Card",
                column: "BoxId");

            migrationBuilder.AddForeignKey(
                name: "FK_Card_Box_BoxId",
                table: "Card",
                column: "BoxId",
                principalTable: "Box",
                principalColumn: "BoxId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
