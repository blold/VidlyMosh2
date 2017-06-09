namespace VidlyMosh2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRentalToDb1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "Rental_Id", "dbo.Rentals");
            DropIndex("dbo.Movies", new[] { "Rental_Id" });
            AddColumn("dbo.Rentals", "DateRented", c => c.DateTime(nullable: false));
            AddColumn("dbo.Rentals", "DateReturned", c => c.DateTime(nullable: false));
            AddColumn("dbo.Rentals", "Movie_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Rentals", "Movie_Id");
            AddForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies", "Id", cascadeDelete: true);
            DropColumn("dbo.Movies", "Rental_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Rental_Id", c => c.Int());
            DropForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.Rentals", new[] { "Movie_Id" });
            DropColumn("dbo.Rentals", "Movie_Id");
            DropColumn("dbo.Rentals", "DateReturned");
            DropColumn("dbo.Rentals", "DateRented");
            CreateIndex("dbo.Movies", "Rental_Id");
            AddForeignKey("dbo.Movies", "Rental_Id", "dbo.Rentals", "Id");
        }
    }
}
