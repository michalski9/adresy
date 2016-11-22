namespace DaysContainer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pensje : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pensjas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Wynagrodzenie = c.Int(nullable: false),
                        Premia = c.Boolean(nullable: false),
                        Nagana = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pensjas");
        }
    }
}
