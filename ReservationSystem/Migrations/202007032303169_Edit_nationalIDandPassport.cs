namespace ReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit_nationalIDandPassport : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "NationalID_PassPortNumber", c => c.String());
            DropColumn("dbo.Clients", "PassPortNumber");
            DropColumn("dbo.Clients", "NationalID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "NationalID", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "PassPortNumber", c => c.String());
            DropColumn("dbo.Clients", "NationalID_PassPortNumber");
        }
    }
}
