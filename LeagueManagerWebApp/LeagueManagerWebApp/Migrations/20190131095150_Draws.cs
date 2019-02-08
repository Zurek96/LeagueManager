using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueManagerWebApp.Data.Migrations
{
    public partial class Draws : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Draws",
                table: "PlayerModel",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Draws",
                table: "PlayerModel");
        }
    }
}
