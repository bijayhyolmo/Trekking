using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trekking.Models;

namespace Trekking.Controllers
{
    public class HomeController : Controller
    {
        //public HomeController(ApplicationDbContext context)
        //{

        //}

        public ActionResult Index()
        {
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

        public ActionResult Nepal()
        {
            return View();
        }
    }
}