using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueManagerWebApp.Data.Migrations
{
    public partial class UserPlayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasVoted",
                table: "PlayerModel",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "PlayerModel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasVoted",
                table: "PlayerModel");

            migrationBuilder.DropColumn(
                name: "User",
                table: "PlayerModel");
        }
    }
}
