namespace LeagueManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LeagueModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LeagueModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.PlayerModels", "LeagueModel_Id", c => c.Int());
            CreateIndex("dbo.PlayerModels", "LeagueModel_Id");
            AddForeignKey("dbo.PlayerModels", "LeagueModel_Id", "dbo.LeagueModels", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlayerModels", "LeagueModel_Id", "dbo.LeagueModels");
            DropIndex("dbo.PlayerModels", new[] { "LeagueModel_Id" });
            DropColumn("dbo.PlayerModels", "LeagueModel_Id");
            DropTable("dbo.LeagueModels");
        }
    }
}
