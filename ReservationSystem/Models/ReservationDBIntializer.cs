using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ReservationSystem.Models
{
    public class ReservationDBIntializer<T> : DropCreateDatabaseIfModelChanges<RRSContext>
    {
        protected override void Seed(RRSContext context)
        {
            //context.Rooms.Add(new Room()
            //{
            //    Floor = 3,
            //    Name = "304B",
            //    TypeID = 0
            //});

            base.Seed(context);
        }
    }
}