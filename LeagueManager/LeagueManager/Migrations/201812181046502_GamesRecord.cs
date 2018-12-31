namespace LeagueManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GamesRecord : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PlayerModels", "GeneralGamesWon", c => c.Int(nullable: false));
            AddColumn("dbo.PlayerModels", "GeneralGamesLost", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PlayerModels", "GeneralGamesLost");
            DropColumn("dbo.PlayerModels", "GeneralGamesWon");
        }
    }
}
