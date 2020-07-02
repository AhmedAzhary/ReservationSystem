namespace ReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Models : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PassPortNumber = c.String(),
                        NationalID = c.Int(nullable: false),
                        HomeAdress = c.String(),
                        EmployerName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        PostalCode = c.Int(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Reason = c.String(),
                        RoomID = c.Int(nullable: false),
                        PatientID = c.Int(nullable: false),
                        ArrivingFrom = c.String(),
                        DoctorName = c.String(),
                        PatientRoomNumber = c.Int(nullable: false),
                        Cash = c.Single(nullable: false),
                        ArrivalDate = c.DateTime(nullable: false),
                        DepartureDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Patients", t => t.PatientID, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.RoomID, cascadeDelete: true)
                .Index(t => t.RoomID)
                .Index(t => t.PatientID);
            
            AddColumn("dbo.Rooms", "TypeID", c => c.Int(nullable: false));
            AddColumn("dbo.Rooms", "Name", c => c.String());
            DropColumn("dbo.Rooms", "Size");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rooms", "Size", c => c.Int(nullable: false));
            DropForeignKey("dbo.Reservations", "RoomID", "dbo.Rooms");
            DropForeignKey("dbo.Reservations", "PatientID", "dbo.Patients");
            DropIndex("dbo.Reservations", new[] { "PatientID" });
            DropIndex("dbo.Reservations", new[] { "RoomID" });
            DropColumn("dbo.Rooms", "Name");
            DropColumn("dbo.Rooms", "TypeID");
            DropTable("dbo.Reservations");
            DropTable("dbo.Patients");
        }
    }
}
