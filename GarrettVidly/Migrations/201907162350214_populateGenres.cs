namespace GarrettVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres VALUES ('Action')");
            Sql("INSERT INTO Genres VALUES ('Comedy')");
            Sql("INSERT INTO Genres VALUES ('Drama')");
            Sql("INSERT INTO Genres VALUES ('Family')");
            Sql("INSERT INTO Genres VALUES ('Science Fiction')");


        }

        public override void Down()
        {
        }
    }
}
