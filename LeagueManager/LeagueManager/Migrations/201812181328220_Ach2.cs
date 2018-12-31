namespace LeagueManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ach2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PlayerModels", "AchievementScore", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PlayerModels", "AchievementScore");
        }
    }
}
