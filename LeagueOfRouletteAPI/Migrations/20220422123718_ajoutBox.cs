using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueOfRouletteAPI.Migrations
{
    public partial class ajoutBox : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BoxId",
                table: "Card",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Box",
                columns: table => new
                {
                    BoxId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Box", x => x.BoxId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Card_Box_BoxId",
                table: "Card");

            migrationBuilder.DropTable(
                name: "Box");

            migrationBuilder.DropIndex(
                name: "IX_Card_BoxId",
                table: "Card");

            migrationBuilder.DropColumn(
                name: "BoxId",
                table: "Card");
        }
    }
}
