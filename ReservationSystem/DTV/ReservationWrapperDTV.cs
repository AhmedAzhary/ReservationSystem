using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservationSystem.DTV
{
    public class ReservationWrapperDTV
    {
        public List<ReservationDTV> Reservations { get; set; }
        public string Name { get; set; }
        public string PassPortNumber { get; set; }
        public int NationalID { get; set; }
        public string HomeAdress { get; set; }
        public string EmployerName { get; set; }
        public DateTime BirthDate { get; set; }
        public int PostalCode { get; set; }
        public int PhoneNumber { get; set; }
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