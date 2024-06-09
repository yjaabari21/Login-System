using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginTest.Models;

namespace LoginTest.Controllers
{
    public class HomeController : Controller
    {
        UsersEntities db = new UsersEntities(); 
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User log)
        {
            var user = db.Users.Where(x => x.UserName == log.UserName && x.Password == log.Password).Count();
            if (user > 0)
            {
                return RedirectToAction("Dashboard");
            }
            else
            {

            }
            return View();
        }
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}