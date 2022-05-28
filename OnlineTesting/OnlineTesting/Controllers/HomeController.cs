using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineTesting.Models;

namespace OnlineTesting.Controllers
{
    public class HomeController : Controller
    {
        private Model_OT db = new Model_OT();
        public ActionResult Index()
        {
            if (db.Students.Count() == 1) ;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}