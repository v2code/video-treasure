namespace VideoTreasure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewColumnsAddedToMovies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "DateAdded");
            DropColumn("dbo.Movies", "Quantity");
            DropColumn("dbo.Movies", "ReleaseDate");
        }
    }
}
