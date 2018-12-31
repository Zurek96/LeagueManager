namespace LeagueManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Double : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PlayerModels", "Elo", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PlayerModels", "Elo", c => c.Int(nullable: false));
        }
    }
}
