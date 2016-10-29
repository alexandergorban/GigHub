namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsCanseledToGig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gigs", "IsCanseled", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Gigs", "IsCanseled");
        }
    }
}
