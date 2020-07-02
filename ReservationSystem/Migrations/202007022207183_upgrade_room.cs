namespace ReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upgrade_room : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rooms", "FreeFrom", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rooms", "FreeFrom", c => c.DateTime(nullable: false));
        }
    }
}
