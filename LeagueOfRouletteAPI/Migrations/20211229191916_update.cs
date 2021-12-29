using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueOfRouletteAPI.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backpack_BackpackCard_BackpackCardId",
                table: "Backpack");

            migrationBuilder.DropForeignKey(
                name: "FK_Card_BackpackCard_BackpackCardId",
                table: "Card");

            migrationBuilder.DropIndex(
                name: "IX_Card_BackpackCardId",
                table: "Card");

            migrationBuilder.DropIndex(
                name: "IX_Backpack_BackpackCardId",
                table: "Backpack");

            migrationBuilder.DropColumn(
                name: "BackpackCardId",
                table: "Card");

            migrationBuilder.DropColumn(
                name: "BackpackCardId",
                table: "Backpack");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BackpackCard",
                newName: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "BackpackCard",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "BackpackCardId",
                table: "Card",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BackpackCardId",
                table: "Backpack",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Card_BackpackCardId",
                table: "Card",
                column: "BackpackCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Backpack_BackpackCardId",
                table: "Backpack",
                column: "BackpackCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Backpack_BackpackCard_BackpackCardId",
                table: "Backpack",
                column: "BackpackCardId",
                principalTable: "BackpackCard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Card_BackpackCard_BackpackCardId",
                table: "Card",
                column: "BackpackCardId",
                principalTable: "BackpackCard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
