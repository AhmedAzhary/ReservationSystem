using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReservationSystem.Models
{
    public class Room
    {
        [Key]
        public int ID { get; set; }
        public int TypeID { get; set; }
        public int Floor { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Reservation> Reservation { set; get; }
    }
}