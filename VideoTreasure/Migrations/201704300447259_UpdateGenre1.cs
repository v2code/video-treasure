namespace VideoTreasure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGenre1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (GenreName) VALUES ('Animation')");
            Sql("INSERT INTO Genres (GenreName) VALUES ('Action')");
            Sql("INSERT INTO Genres (GenreName) VALUES ('Comedy')");
            Sql("INSERT INTO Genres (GenreName) VALUES ('Drama')");
        }
        
        public override void Down()
        {
        }
    }
}
