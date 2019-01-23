using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueManagerWebApp.Data.Migrations
{
    public partial class Voting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VotingModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsOpened = table.Column<bool>(nullable: false),
                    Winner = table.Column<string>(nullable: true),
                    Stand = table.Column<int>(nullable: false),
                    Mod = table.Column<int>(nullable: false),
                    Pau = table.Column<int>(nullable: false),
                    Rain = table.Column<int>(nullable: false),
                    Draft = table.Column<int>(nullable: false),
                    Sing = table.Column<int>(nullable: false),
                    Tri = table.Column<int>(nullable: false),
                    Pea = table.Column<int>(nullable: false),
                    War = table.Column<int>(nullable: false),
                    Back = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VotingModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VotingModel");
        }
    }
}
