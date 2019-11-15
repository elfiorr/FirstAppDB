using Blank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blank.Controllers
{
    public class HomeController : Controller
    {
        DateTime timeOfWedding = new DateTime(2019,4,4);

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            int day = DateTime.Now.Day;

            ViewBag.Greeting = hour < 18 ? "Dzień dobry" : "Dobry wieczór";
            ViewBag.Time = timeOfWedding.ToString("d");
            
            return View();
        }

        [HttpGet]
        public ViewResult Blank()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Blank(GuestResponse guestResponse)
        {
            return View();
        }
    }
}