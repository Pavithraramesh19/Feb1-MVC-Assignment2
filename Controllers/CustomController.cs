using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_2_MVC.Controllers
{
    public class CustomController : Controller
    {
        // GET: Custom
        public ActionResult Index()
        {
            ViewBag.Msg = "These are the Customers";
            
            List<string> list = new List<string>
            {
             "Robert",
            "George",
            "Anabell",
            "Nitin",
            "Deepak"
            };
            ViewBag.nameList = list;
            return View();
        }
        public ActionResult RedirectDemo()
        {
            TempData["displaymsg"] = "Thanks for visiting us!!!";
            return View();
        }
    }
}