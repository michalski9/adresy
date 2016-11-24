namespace DaysContainer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class typ : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Days", "Ocena", c => c.Double(nullable: false));
            AlterColumn("dbo.Days", "Stopien_zadowolenia", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Days", "Stopien_zadowolenia", c => c.Int(nullable: false));
            AlterColumn("dbo.Days", "Ocena", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
