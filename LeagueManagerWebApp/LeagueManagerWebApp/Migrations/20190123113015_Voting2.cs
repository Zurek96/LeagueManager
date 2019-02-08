using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueManagerWebApp.Data.Migrations
{
    public partial class Voting2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "VotingModel",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VotingModel_EventId",
                table: "VotingModel",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_VotingModel_EventModel_EventId",
                table: "VotingModel",
                column: "EventId",
                principalTable: "EventModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VotingModel_EventModel_EventId",
                table: "VotingModel");

            migrationBuilder.DropIndex(
                name: "IX_VotingModel_EventId",
                table: "VotingModel");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "VotingModel");
        }
    }
}
