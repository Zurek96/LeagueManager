namespace LeagueManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LeagueModel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LeagueModels", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.LeagueModels", "Name");
        }
    }
}
