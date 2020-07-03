using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservationSystem.DTV
{
    public class ReservationDTV
    {
        public int ID { get; set; }
        public string Reason { get; set; }
        public int RoomID { get; set; }
        public int PatientID { get; set; }
        public string ArrivingFrom { get; set; }
        public string DoctorName { get; set; }
        public int PatientRoomNumber { get; set; }
        public float Cash { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
    }
}