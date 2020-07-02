﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReservationSystem.Models
{
    public class Patient
    {
        [Key]
        public int ID { get; set; }
        
        public string Name { get; set; }
        public string PassPortNumber { get; set; }
        public int NationalID  { get; set; }
        public string HomeAdress { get; set; }
        public string EmployerName { get; set; }
        public DateTime BirthDate { get; set; }
        public int PostalCode { get; set; }
        public int PhoneNumber { get; set; }

    }
}