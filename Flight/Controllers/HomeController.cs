using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Flight.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Members = new List<string>()
            {
                "23DH113972 - Trịnh Hoàng Tú",
                "23DH114872 - Đoàn Ngọc Trân",
                "23DH114365 - Nguyễn Hoàng Kha",
                "23DH113375 - Trần Minh Thiện",
                "23DH113290 - Huỳnh Việt Thắng"
            };
            //mssv - họ tên
            return View();
        }
    }
}