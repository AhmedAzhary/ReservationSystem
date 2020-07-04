namespace ReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PatientRoom : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "PatientRoomNumber", c => c.String());
            AlterColumn("dbo.Clients", "PatientName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "PatientName", c => c.Int(nullable: false));
            AlterColumn("dbo.Clients", "PatientRoomNumber", c => c.Int(nullable: false));
        }
    }
}
