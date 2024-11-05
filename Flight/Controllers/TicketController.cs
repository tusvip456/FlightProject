using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Flight.Controllers
{
    public class TicketController : Controller
    {
        #region chưa đụng tới
        /*public class TicketModel
        {
            public string Departure { get; set; }
            public string Destination { get; set; }
            public DateTime DepartureDate { get; set; }
            public int NumberOfPassengers { get; set; }
            public decimal Price { get; set; }
            // Các thuộc tính khác như Thông tin khách hàng, mã chuyến bay,...
        }
        public class TicketDetailViewModel
        {
            public string TicketClass { get; set; }
            public decimal Price { get; set; }
            public string Benefits { get; set; }
        }*/
        #endregion
        // GET: Ticket
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Details(string ticketClass,string flightTime, decimal? price, string benefits)
        {
            if (price == null)
            {
                // Xử lý trường hợp không có giá trị
                ViewBag.Message = "Chọn vé chưa mà qua đây ;)";
            }
            ViewBag.TicketClass = ticketClass;
            ViewBag.FlightTime = flightTime;
            ViewBag.TicketPrice = price;
            ViewBag.TicketBenefits = benefits;
            return View();
        }
    }
}