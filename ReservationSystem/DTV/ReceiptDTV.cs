using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservationSystem.DTV
{
    public class ReceiptDTV
    {
        public string ArrivingFrom { get; set; }
        public float Cash { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public string Reason { get; set; }
        public string Name { get; set; }
        public string IdOrPassPort { get; set; }
        public string Address { get; set; }
        public string Nationality { get; set; }
        public int NationalityID { get; set; }
        public DateTime BirthDate { get; set; }
        public string PostCode { get; set; }
        public string PhoneNumber { get; set; }
        public string DoctorName { get; set; }
        public string EmployerName { get; set; }
        public string RoomNumber { get; set; }
        public string FloorNumber { get; set; }

    }
}