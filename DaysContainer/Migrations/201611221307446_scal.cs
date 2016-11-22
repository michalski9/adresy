namespace DaysContainer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class scal : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pracowniks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Imie = c.String(),
                        Nazwisko = c.String(),
                        PAdres_Id = c.Int(),
                        PPensja_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adres", t => t.PAdres_Id)
                .ForeignKey("dbo.Pensjas", t => t.PPensja_Id)
                .Index(t => t.PAdres_Id)
                .Index(t => t.PPensja_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pracowniks", "PPensja_Id", "dbo.Pensjas");
            DropForeignKey("dbo.Pracowniks", "PAdres_Id", "dbo.Adres");
            DropIndex("dbo.Pracowniks", new[] { "PPensja_Id" });
            DropIndex("dbo.Pracowniks", new[] { "PAdres_Id" });
            DropTable("dbo.Pracowniks");
        }
    }
}
