namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BegeniDurum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Durum", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "Durum");
        }
    }
}
