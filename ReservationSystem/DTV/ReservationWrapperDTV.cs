using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReservationSystem.DTV
{
    public class ReservationWrapperDTV
    {

        public List<ReservationDTV> Reservations { get; set; }
        [Required(ErrorMessage = "هذا البند مطلوب")]
        public string Name { get; set; }
        [Required(ErrorMessage = "هذا البند مطلوب")]
        public string PatientName { get; set; }
        [Required(ErrorMessage = "هذا البند مطلوب")]
        public string NationalID_PassPortNumber { get; set; }
        [Required(ErrorMessage = "هذا البند مطلوب")]
        public string HomeAdress { get; set; }
        [Required(ErrorMessage = "هذا البند مطلوب")]
        public string EmployerName { get; set; }
        [Required(ErrorMessage = "هذا البند مطلوب")]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "هذا البند مطلوب")]
        public int? PostalCode { get; set; }
        [Required(ErrorMessage = "هذا البند مطلوب")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "هذا البند مطلوب")]
        public string Reason { get; set; }
        [Required(ErrorMessage = "هذا البند مطلوب")]
        public int RoomID { get; set; }
        [Required(ErrorMessage = "هذا البند مطلوب")]
        public int PatientID { get; set; }
        [Required(ErrorMessage = "هذا البند مطلوب")]
        public string ArrivingFrom { get; set; }
        [Required(ErrorMessage = "هذا البند مطلوب")]
        public string DoctorName { get; set; }
        [Required(ErrorMessage = "هذا البند مطلوب")]
        public string JobTitle { get; set; }
        [Required(ErrorMessage = "هذا البند مطلوب")]
        public string PatientRoomNumber { get; set; }
        [Required(ErrorMessage = "هذا البند مطلوب")]
        public int Nationality { get; set; }
        [Required(ErrorMessage = "هذا البند مطلوب")]
        public float Cash { get; set; }
        [Required(ErrorMessage = "هذا البند مطلوب")]
        public DateTime ArrivalDate { get; set; }
        [Required(ErrorMessage = "هذا البند مطلوب")]
        public DateTime DepartureDate { get; set; }
    }
}