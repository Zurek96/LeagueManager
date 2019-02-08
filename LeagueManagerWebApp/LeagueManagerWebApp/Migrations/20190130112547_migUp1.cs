using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueManagerWebApp.Data.Migrations
{
    public partial class migUp1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LeagueName",
                table: "MatchupModel");

            migrationBuilder.DropColumn(
                name: "LeagueName",
                table: "MatchupHistoryModel");

            migrationBuilder.DropColumn(
                name: "LeagueName",
                table: "EventModel");

            migrationBuilder.AddColumn<int>(
                name: "LeagueId",
                table: "MatchupModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LeagueId",
                table: "MatchupHistoryModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LeagueId",
                table: "EventModel",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LeagueId",
                table: "MatchupModel");

            migrationBuilder.DropColumn(
                name: "LeagueId",
                table: "MatchupHistoryModel");

            migrationBuilder.DropColumn(
                name: "LeagueId",
                table: "EventModel");

            migrationBuilder.AddColumn<string>(
                name: "LeagueName",
                table: "MatchupModel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LeagueName",
                table: "MatchupHistoryModel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LeagueName",
                table: "EventModel",
                nullable: true);
        }
    }
}
