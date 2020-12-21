namespace FutbolDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TakimlarEklendi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Maçlar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MacTarih = c.DateTime(),
                        Takim1Id = c.Int(nullable: false),
                        Takim2Id = c.Int(nullable: false),
                        Skor1 = c.Int(nullable: false),
                        Skor2 = c.Int(nullable: false),
                        Sonuc = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Takimlar", t => t.Takim1Id)
                .ForeignKey("dbo.Takimlar", t => t.Takim2Id)
                .Index(t => t.Takim1Id)
                .Index(t => t.Takim2Id);
            
            CreateTable(
                "dbo.Takimlar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TakimAd = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Oyuncular",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OyuncuAd = c.String(),
                        TakimId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Takimlar", t => t.TakimId)
                .Index(t => t.TakimId);
            
            CreateTable(
                "dbo.Renkler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RenkAd = c.String(),
                        Red = c.Byte(nullable: false),
                        Green = c.Byte(nullable: false),
                        Blue = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RenkTakims",
                c => new
                    {
                        Renk_Id = c.Int(nullable: false),
                        Takim_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Renk_Id, t.Takim_Id })
                .ForeignKey("dbo.Renkler", t => t.Renk_Id, cascadeDelete: true)
                .ForeignKey("dbo.Takimlar", t => t.Takim_Id, cascadeDelete: true)
                .Index(t => t.Renk_Id)
                .Index(t => t.Takim_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Maçlar", "Takim2Id", "dbo.Takimlar");
            DropForeignKey("dbo.Maçlar", "Takim1Id", "dbo.Takimlar");
            DropForeignKey("dbo.RenkTakims", "Takim_Id", "dbo.Takimlar");
            DropForeignKey("dbo.RenkTakims", "Renk_Id", "dbo.Renkler");
            DropForeignKey("dbo.Oyuncular", "TakimId", "dbo.Takimlar");
            DropIndex("dbo.RenkTakims", new[] { "Takim_Id" });
            DropIndex("dbo.RenkTakims", new[] { "Renk_Id" });
            DropIndex("dbo.Oyuncular", new[] { "TakimId" });
            DropIndex("dbo.Maçlar", new[] { "Takim2Id" });
            DropIndex("dbo.Maçlar", new[] { "Takim1Id" });
            DropTable("dbo.RenkTakims");
            DropTable("dbo.Renkler");
            DropTable("dbo.Oyuncular");
            DropTable("dbo.Takimlar");
            DropTable("dbo.Maçlar");
        }
    }
}
