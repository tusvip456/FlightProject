using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Flight.Controllers
{
    public class TicketController : Controller
    {
        public class TicketDetailViewModel
        {
            public string TicketClass { get; set; }
            public decimal Price { get; set; }
            public string Benefits { get; set; }
        }
        // GET: Ticket
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Details()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Detail(string ticketClass, decimal price, string benefits)
        {
            var model = new TicketDetailViewModel
            {
                TicketClass = ticketClass,
                Price = price,
                Benefits = benefits
            };
            return View(model);
        }
    }
}