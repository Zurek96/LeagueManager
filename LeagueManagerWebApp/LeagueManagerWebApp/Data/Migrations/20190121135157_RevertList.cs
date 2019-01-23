using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueManagerWebApp.Data.Migrations
{
    public partial class RevertList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerModel_LeagueModel_LeagueModelId",
                table: "PlayerModel");

            migrationBuilder.DropIndex(
                name: "IX_PlayerModel_LeagueModelId",
                table: "PlayerModel");

            migrationBuilder.DropColumn(
                name: "LeagueModelId",
                table: "PlayerModel");

            migrationBuilder.AddColumn<string>(
                name: "Players",
                table: "LeagueModel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Players",
                table: "LeagueModel");

            migrationBuilder.AddColumn<int>(
                name: "LeagueModelId",
                table: "PlayerModel",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlayerModel_LeagueModelId",
                table: "PlayerModel",
                column: "LeagueModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerModel_LeagueModel_LeagueModelId",
                table: "PlayerModel",
                column: "LeagueModelId",
                principalTable: "LeagueModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
