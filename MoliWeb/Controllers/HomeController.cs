using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoliWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "描述關於自己的地方.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "其他.";

            return View();
        }
    }
}