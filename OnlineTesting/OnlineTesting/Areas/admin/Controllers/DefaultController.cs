using OnlineTesting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineTesting.Areas.admin.Controllers
{
    public class DefaultController : Controller
    {
        private Model_OT db = new Model_OT();

        // GET: admin/Default
        [HttpGet]
        public ActionResult Login()
        {
            if (Session["admin"] != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var user = username;
            var pass = password;
            var acc = db.Admins.SingleOrDefault(x => x.taikhoan == user && x.Password == pass);
            if (acc != null)
            {
                Session["admin"] = acc;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }
    }
}