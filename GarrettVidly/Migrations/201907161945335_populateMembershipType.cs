namespace GarrettVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET TypeName = 'Pay as You Go' WHERE DurationInMonths = 0");
            Sql("UPDATE MembershipTypes SET TypeName = 'Monthly' WHERE DurationInMonths = 1");
            Sql("UPDATE MembershipTypes SET TypeName = 'Quarterly' WHERE DurationInMonths = 3");
            Sql("UPDATE MembershipTypes SET TypeName = 'Yearly' WHERE DurationInMonths = 12");


        }

        public override void Down()
        {
        }
    }
}
