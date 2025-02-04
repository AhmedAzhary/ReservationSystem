﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReservationSystem.Models
{
    public class Reservation
    {
        [Key]
        public int ID { get; set; }
        public string Reason { get; set; }
        [ForeignKey("Room")]
        public int RoomID { get; set; }
        [ForeignKey("Client")]
        public int ClientID { get; set; }
        public string ArrivingFrom { get; set; }
        public float Cash { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }

        public virtual Room Room { set; get; }
        public virtual Client Client { set; get; }

    }
}