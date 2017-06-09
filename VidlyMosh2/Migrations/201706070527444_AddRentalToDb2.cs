namespace VidlyMosh2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRentalToDb2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rentals", "DateReturned", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rentals", "DateReturned", c => c.DateTime(nullable: false));
        }
    }
}
