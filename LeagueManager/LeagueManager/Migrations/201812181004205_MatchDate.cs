namespace LeagueManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MatchDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PlayerModels", "GamesWon", c => c.Int(nullable: false));
            AddColumn("dbo.PlayerModels", "GamesLost", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PlayerModels", "GamesLost");
            DropColumn("dbo.PlayerModels", "GamesWon");
        }
    }
}
