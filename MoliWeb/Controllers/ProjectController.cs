using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoliWeb.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult Pygame()
        {
            return View();
            
        }

        public ActionResult AccountApp()
        {
            return View();
        }
        public ActionResult Insurance()
        {
            return View();
        }
        public ActionResult InterActWeb()
        {
            return View();
        }
        public ActionResult UnityGame()
        {
            return View();
        }
        public ActionResult SqlProject()
        {
            return View();
        }
    }
}
