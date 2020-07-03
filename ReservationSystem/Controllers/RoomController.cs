using ReservationSystem.DTV;
using ReservationSystem.Logic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReservationSystem.Controllers
{
    public class RoomController : Controller
    {
        public RoomController()
        {

        }
        // GET: Room
        public ActionResult Index()
        {
            RoomLogic roomLogic = new RoomLogic();
            var rooms = roomLogic.GetRoomsByFilter(new DTV.RoomFilter());
            LoadDDL();
            return View(rooms);
        }

        
        public ActionResult Reserve(string id)
        {
            LoadDDL();
            return View(new RoomLogic().GetReservations(int.Parse(id)));
        }
        [HttpPost]
        public ActionResult AddReserve(ReservationWrapperDTV model)
        {
            return Json(new
            {
                list = ConvertViewToString("~/Views/Room/_reservationListing.cshtml", model)
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Filter(RoomFilter filter)
        {
            var model = new RoomLogic().GetRoomsByFilter(filter);
            return Json(new
            {
                list = ConvertViewToString("~/Views/Room/_Listing.cshtml",model)
            }, JsonRequestBehavior.AllowGet);
        }

        private void LoadDDL()
        {
            ViewBag.RoomTypes = Enum.GetValues(typeof(enums.RoomType)).Cast<enums.RoomType>().Select(v => new SelectListItem
            {
                Text = EnumHelper<enums.RoomType>.GetDisplayValue(v),
                Value = ((int)v).ToString()
            }).ToList();

            ViewBag.Nationality = Enum.GetValues(typeof(enums.Nationality)).Cast<enums.Nationality>().Select(v => new SelectListItem
            {
                Text = EnumHelper<enums.Nationality>.GetDisplayValue(v),
                Value = ((int)v).ToString()
            }).ToList();

            ViewBag.Floor = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Text = "3",
                    Value = "3"
                },
                 new SelectListItem()
                {
                    Text = "4",
                    Value = "4"
                },
            };
            
        }

        private string ConvertViewToString(string viewName, object model)
        {
            ViewData.Model = model;
            using (StringWriter writer = new StringWriter())
            {
                ViewEngineResult vResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
                ViewContext vContext = new ViewContext(this.ControllerContext, vResult.View, ViewData, new TempDataDictionary(), writer);
                vResult.View.Render(vContext, writer);
                return writer.ToString();
            }
        }
    }
}
