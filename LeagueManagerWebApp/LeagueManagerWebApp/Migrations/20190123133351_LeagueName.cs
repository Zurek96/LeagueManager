using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueManagerWebApp.Data.Migrations
{
    public partial class LeagueName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchupModel_LeagueModel_LeagueId",
                table: "MatchupModel");

            migrationBuilder.DropIndex(
                name: "IX_MatchupModel_LeagueId",
                table: "MatchupModel");

            migrationBuilder.DropColumn(
                name: "LeagueId",
                table: "MatchupModel");

            migrationBuilder.AddColumn<string>(
                name: "LeagueName",
                table: "MatchupModel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LeagueName",
                table: "MatchupModel");

            migrationBuilder.AddColumn<int>(
                name: "LeagueId",
                table: "MatchupModel",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MatchupModel_LeagueId",
                table: "MatchupModel",
                column: "LeagueId");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchupModel_LeagueModel_LeagueId",
                table: "MatchupModel",
                column: "LeagueId",
                principalTable: "LeagueModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
