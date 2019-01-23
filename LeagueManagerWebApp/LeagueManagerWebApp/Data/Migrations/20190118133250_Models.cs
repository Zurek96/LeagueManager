using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueManagerWebApp.Data.Migrations
{
    public partial class Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AchievementModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AchievementModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeagueModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Players = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeagueModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayerModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Elo = table.Column<int>(nullable: false),
                    AchievementScore = table.Column<int>(nullable: false),
                    Wins = table.Column<int>(nullable: false),
                    Losses = table.Column<int>(nullable: false),
                    MatchesPlayed = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Format = table.Column<string>(nullable: true),
                    WinnerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventModel_PlayerModel_WinnerId",
                        column: x => x.WinnerId,
                        principalTable: "PlayerModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MatchupModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Player1Id = table.Column<int>(nullable: true),
                    Player2Id = table.Column<int>(nullable: true),
                    WinnerId = table.Column<int>(nullable: true),
                    LoserId = table.Column<int>(nullable: true),
                    IsFinished = table.Column<bool>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchupModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchupModel_PlayerModel_LoserId",
                        column: x => x.LoserId,
                        principalTable: "PlayerModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchupModel_PlayerModel_Player1Id",
                        column: x => x.Player1Id,
                        principalTable: "PlayerModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchupModel_PlayerModel_Player2Id",
                        column: x => x.Player2Id,
                        principalTable: "PlayerModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchupModel_PlayerModel_WinnerId",
                        column: x => x.WinnerId,
                        principalTable: "PlayerModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventModel_WinnerId",
                table: "EventModel",
                column: "WinnerId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AchievementModel");

            migrationBuilder.DropTable(
                name: "EventModel");

            migrationBuilder.DropTable(
                name: "LeagueModel");

            migrationBuilder.DropTable(
                name: "MatchupModel");

            migrationBuilder.DropTable(
                name: "PlayerModel");
        }
    }
}
