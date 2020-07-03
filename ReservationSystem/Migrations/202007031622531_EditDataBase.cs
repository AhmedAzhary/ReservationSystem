namespace ReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditDataBase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reservations", "PatientID", "dbo.Patients");
            DropIndex("dbo.Reservations", new[] { "PatientID" });
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PassPortNumber = c.String(),
                        NationalID = c.Int(nullable: false),
                        HomeAddress = c.String(),
                        EmployerName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        PostalCode = c.Int(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                        DoctorName = c.String(),
                        PatientRoomNumber = c.Int(nullable: false),
                        PatientName = c.Int(nullable: false),
                        NationalityID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Reservations", "ClientID", c => c.Int(nullable: false));
            CreateIndex("dbo.Reservations", "ClientID");
            AddForeignKey("dbo.Reservations", "ClientID", "dbo.Clients", "ID", cascadeDelete: true);
            DropColumn("dbo.Reservations", "PatientID");
            DropColumn("dbo.Reservations", "DoctorName");
            DropColumn("dbo.Reservations", "PatientRoomNumber");
            DropTable("dbo.Patients");
        }
        
        public override void Down()
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
            
            AddColumn("dbo.Reservations", "PatientRoomNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Reservations", "DoctorName", c => c.String());
            AddColumn("dbo.Reservations", "PatientID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Reservations", "ClientID", "dbo.Clients");
            DropIndex("dbo.Reservations", new[] { "ClientID" });
            DropColumn("dbo.Reservations", "ClientID");
            DropTable("dbo.Clients");
            CreateIndex("dbo.Reservations", "PatientID");
            AddForeignKey("dbo.Reservations", "PatientID", "dbo.Patients", "ID", cascadeDelete: true);
        }
    }
}
