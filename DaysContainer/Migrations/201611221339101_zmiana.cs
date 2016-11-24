namespace DaysContainer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zmiana : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Adres", "NumerDomu", c => c.String());
            AlterColumn("dbo.Adres", "NumerMieszkania", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Adres", "NumerMieszkania", c => c.Int(nullable: false));
            AlterColumn("dbo.Adres", "NumerDomu", c => c.Int(nullable: false));
        }
    }
}
