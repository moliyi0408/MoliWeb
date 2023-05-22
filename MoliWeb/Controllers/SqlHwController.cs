using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoliWeb.Controllers
{
    public class SqlHwController : Controller
    {
        // GET: SqlHw
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }
        public ActionResult reply()
        {
            return Content("傳送成功");
        }
    }
}