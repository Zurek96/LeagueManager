namespace LeagueManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ListChange : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PlayerModels", "LeagueModel_Id", "dbo.LeagueModels");
            DropIndex("dbo.PlayerModels", new[] { "LeagueModel_Id" });
            DropColumn("dbo.PlayerModels", "LeagueModel_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PlayerModels", "LeagueModel_Id", c => c.Int());
            CreateIndex("dbo.PlayerModels", "LeagueModel_Id");
            AddForeignKey("dbo.PlayerModels", "LeagueModel_Id", "dbo.LeagueModels", "Id");
        }
    }
}
