namespace LeagueManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Turns : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TurnAggregationModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WinnerName = c.String(),
                        Matches = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TurnAggregationModels");
        }
    }
}
