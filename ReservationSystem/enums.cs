using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReservationSystem
{
    public static class enums
    {
        public enum RoomType
        {
            [Display(Name = "فردى")]
            Single = 0,
            [Display(Name = "زوجى")]
            Double = 1,
            [Display(Name = "سويت")]
            Suite = 2
        }
        public enum Nationality
        {
            [Display(Name = "مصرى")]
            Egyptian = 1,
            [Display(Name = "غير مصرى")]
            NonEgyptian = 0
        }
    }
}