using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ReservationSystem.Models
{
    public class RRSContext : DbContext
    {
        public RRSContext() :base("name=ReservationSystem")
        {
            Database.SetInitializer(new ReservationDBIntializer<RRSContext>());
        }
        public IDbSet<Room> Rooms { set; get; }
        public IDbSet<Reservation> Reservations { set; get; }
        public IDbSet<Patient> Patients  { set; get; }
    }
}