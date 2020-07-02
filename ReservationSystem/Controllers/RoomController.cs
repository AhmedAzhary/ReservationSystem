using ReservationSystem.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReservationSystem.Controllers
{
    public class RoomController : Controller
    {
        // GET: Room
        public ActionResult Index()
        {
            RoomLogic roomLogic = new RoomLogic();
            var rooms = roomLogic.GetRoomsByFilter(new DTV.RoomFilter());
            return View(rooms);
        }

        // GET: Room/Details/5
        public ActionResult Reserve (string id)
        {
            return View();
        }
    }
}
