namespace LeagueManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ListChange2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LeagueModels", "Competitors", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.LeagueModels", "Competitors");
        }
    }
}
