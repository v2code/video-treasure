namespace VideoTreasure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMigrationType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET MembershipName = 'Pay As You Go' where Id=1");
            Sql("UPDATE MembershipTypes SET MembershipName = 'Monthly' where Id=2");
            Sql("UPDATE MembershipTypes SET MembershipName = '3 Months' where Id=3");
            Sql("UPDATE MembershipTypes SET MembershipName = 'Annual' where Id=4");
        }
        
        public override void Down()
        {
        }
    }
}
