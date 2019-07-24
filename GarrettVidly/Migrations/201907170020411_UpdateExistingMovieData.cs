namespace GarrettVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateExistingMovieData : DbMigration
    {
        public override void Up()
        {
            Sql("Update Movies set ReleaseDate = 2/20/1995, AddedDate = 6/25/1995, NumberInStock = 3  where Id = 1");
            Sql("Update Movies set ReleaseDate = 3/20/2002, AddedDate = 7/20/2002, NumberInStock = 4  where Id = 4");
            Sql("Update Movies set ReleaseDate = 8/20/1985, AddedDate = 1/20/1986, NumberInStock = 1  where Id = 5");
            Sql("Update Movies set ReleaseDate = 10/10/2006, AddedDate = 3/25/2007, NumberInStock = 7  where Id = 6");



        }

        public override void Down()
        {
        }
    }
}
