using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservationSystem.DTV
{
    public class RoomDTV
    {
        public int ID { get; set; }
        public string IDEncrypted { get; set; }
        public int TypeID { get; set; }
        public int Floor { get; set; }
        public string Name { get; set; }
    }
}