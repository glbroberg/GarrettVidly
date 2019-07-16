namespace GarrettVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNameToMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "TypeName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "TypeName");
        }
    }
}
