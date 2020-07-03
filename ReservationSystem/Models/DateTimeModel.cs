using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReservationSystem.Models
{
    public class DateTimeModel
    {
        [Display(Name = "Enter Date")]
        public DateTime EnterDate { get; set; }
    }
}