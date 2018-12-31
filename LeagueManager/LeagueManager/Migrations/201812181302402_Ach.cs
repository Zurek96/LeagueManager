namespace LeagueManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ach : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AchievementModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Score = c.Int(nullable: false),
                        ListOfPlayers = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AchievementModels");
        }
    }
}
