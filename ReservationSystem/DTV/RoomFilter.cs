using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservationSystem.DTV
{
    public class RoomFilter
    {
        public DateTime? AvilableFrom { get; set; }
        public int? Floor { get; set; }
        public int? Type { get; set; }
        public string Name { get; set; }
    }
}