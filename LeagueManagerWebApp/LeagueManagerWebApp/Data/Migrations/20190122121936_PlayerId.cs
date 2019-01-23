using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueManagerWebApp.Data.Migrations
{
    public partial class PlayerId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchupModel_PlayerModel_LoserId",
                table: "MatchupModel");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchupModel_PlayerModel_Player1Id",
                table: "MatchupModel");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchupModel_PlayerModel_Player2Id",
                table: "MatchupModel");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchupModel_PlayerModel_WinnerId",
                table: "MatchupModel");

            migrationBuilder.DropIndex(
                name: "IX_MatchupModel_LoserId",
                table: "MatchupModel");

            migrationBuilder.DropIndex(
                name: "IX_MatchupModel_Player1Id",
                table: "MatchupModel");

            migrationBuilder.DropIndex(
                name: "IX_MatchupModel_Player2Id",
                table: "MatchupModel");

            migrationBuilder.DropIndex(
                name: "IX_MatchupModel_WinnerId",
                table: "MatchupModel");

            migrationBuilder.DropColumn(
                name: "LoserId",
                table: "MatchupModel");

            migrationBuilder.DropColumn(
                name: "Player1Id",
                table: "MatchupModel");

            migrationBuilder.DropColumn(
                name: "Player2Id",
                table: "MatchupModel");

            migrationBuilder.DropColumn(
                name: "WinnerId",
                table: "MatchupModel");

            migrationBuilder.AddColumn<int>(
                name: "Loser",
                table: "MatchupModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Player1",
                table: "MatchupModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Player2",
                table: "MatchupModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Winner",
                table: "MatchupModel",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Loser",
                table: "MatchupModel");

            migrationBuilder.DropColumn(
                name: "Player1",
                table: "MatchupModel");

            migrationBuilder.DropColumn(
                name: "Player2",
                table: "MatchupModel");

            migrationBuilder.DropColumn(
                name: "Winner",
                table: "MatchupModel");

            migrationBuilder.AddColumn<int>(
                name: "LoserId",
                table: "MatchupModel",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Player1Id",
                table: "MatchupModel",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Player2Id",
                table: "MatchupModel",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WinnerId",
                table: "MatchupModel",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MatchupModel_LoserId",
                table: "MatchupModel",
                column: "LoserId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchupModel_Player1Id",
                table: "MatchupModel",
                column: "Player1Id");

            migrationBuilder.CreateIndex(
                name: "IX_MatchupModel_Player2Id",
                table: "MatchupModel",
                column: "Player2Id");

            migrationBuilder.CreateIndex(
                name: "IX_MatchupModel_WinnerId",
                table: "MatchupModel",
                column: "WinnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchupModel_PlayerModel_LoserId",
                table: "MatchupModel",
                column: "LoserId",
                principalTable: "PlayerModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchupModel_PlayerModel_Player1Id",
                table: "MatchupModel",
                column: "Player1Id",
                principalTable: "PlayerModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchupModel_PlayerModel_Player2Id",
                table: "MatchupModel",
                column: "Player2Id",
                principalTable: "PlayerModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchupModel_PlayerModel_WinnerId",
                table: "MatchupModel",
                column: "WinnerId",
                principalTable: "PlayerModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
