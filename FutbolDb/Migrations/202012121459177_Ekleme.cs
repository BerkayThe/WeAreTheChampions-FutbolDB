namespace FutbolDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ekleme : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Maçlar", "Skor1", c => c.Int());
            AlterColumn("dbo.Maçlar", "Skor2", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Maçlar", "Skor2", c => c.Int(nullable: false));
            AlterColumn("dbo.Maçlar", "Skor1", c => c.Int(nullable: false));
        }
    }
}
