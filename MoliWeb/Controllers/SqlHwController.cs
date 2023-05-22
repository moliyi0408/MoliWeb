using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoliWeb.Models;

namespace MoliWeb.Controllers
{
    public class SqlHwController : Controller
    {
    
        // GET: SqlHw
        public ActionResult Index()
        {
       
            ////獲取UserInfor 表中的數據
            SqlHelper sqlHelper = new SqlHelper();
            List<Userinfo> userinfos = sqlHelper.GetUser();
            ViewBag.userinfos = userinfos;
            
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Userinfo userinfo)
        {
            SqlHelper sqlHelper = new SqlHelper();
            try
            {
                sqlHelper.NewUserInfo(userinfo);
            }
            catch(Exception e)
            {

                Console.WriteLine("發生錯誤：{0}", e.Message);
            }

            //return View();
            return RedirectToAction("Index");
        }
        //public ActionResult reply()
        //{
        //    return Content("傳送成功");
        //}
    }
}