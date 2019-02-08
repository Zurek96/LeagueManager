using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueManagerWebApp.Data.Migrations
{
    public partial class Events : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventModel_PlayerModel_WinnerId",
                table: "EventModel");

            migrationBuilder.DropIndex(
                name: "IX_EventModel_WinnerId",
                table: "EventModel");

            migrationBuilder.DropColumn(
                name: "WinnerId",
                table: "EventModel");

            migrationBuilder.AlterColumn<int>(
                name: "Format",
                table: "EventModel",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LeagueName",
                table: "EventModel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Winner",
                table: "EventModel",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isFinished",
                table: "EventModel",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LeagueName",
                table: "EventModel");

            migrationBuilder.DropColumn(
                name: "Winner",
                table: "EventModel");

            migrationBuilder.DropColumn(
                name: "isFinished",
                table: "EventModel");

            migrationBuilder.AlterColumn<string>(
                name: "Format",
                table: "EventModel",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "WinnerId",
                table: "EventModel",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EventModel_WinnerId",
                table: "EventModel",
                column: "WinnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventModel_PlayerModel_WinnerId",
                table: "EventModel",
                column: "WinnerId",
                principalTable: "PlayerModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
