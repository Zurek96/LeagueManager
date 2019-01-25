using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueManagerWebApp.Data.Migrations
{
    public partial class MatchupHistory3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "MatchupModel");

            migrationBuilder.CreateTable(
                name: "MatchupHistoryModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Player1 = table.Column<string>(nullable: true),
                    Player2 = table.Column<string>(nullable: true),
                    Winner = table.Column<string>(nullable: true),
                    Loser = table.Column<string>(nullable: true),
                    IsFinished = table.Column<bool>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    LeagueName = table.Column<string>(nullable: true),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchupHistoryModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatchupHistoryModel");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "MatchupModel",
                nullable: false,
                defaultValue: "");
        }
    }
}
