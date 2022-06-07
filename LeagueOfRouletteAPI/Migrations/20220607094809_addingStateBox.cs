using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueOfRouletteAPI.Migrations
{
    public partial class addingStateBox : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StateBoxId",
                table: "Box",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "StateBox",
                columns: table => new
                {
                    StateBoxId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateBox", x => x.StateBoxId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Box_StateBoxId",
                table: "Box",
                column: "StateBoxId");

            migrationBuilder.AddForeignKey(
                name: "FK_Box_StateBox_StateBoxId",
                table: "Box",
                column: "StateBoxId",
                principalTable: "StateBox",
                principalColumn: "StateBoxId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Box_StateBox_StateBoxId",
                table: "Box");

            migrationBuilder.DropTable(
                name: "StateBox");

            migrationBuilder.DropIndex(
                name: "IX_Box_StateBoxId",
                table: "Box");

            migrationBuilder.DropColumn(
                name: "StateBoxId",
                table: "Box");
        }
    }
}
