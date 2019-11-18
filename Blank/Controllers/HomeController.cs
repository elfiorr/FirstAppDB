using Blank.DB;
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
        private GuestResponseContext db = new GuestResponseContext();
        DateTime timeOfWedding = new DateTime(2019, 4, 4);

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            int day = DateTime.Now.Day;

            ViewBag.Greeting = hour < 18 ? "Dzień dobry" : "Dobry wieczór";
            ViewBag.Time = timeOfWedding.ToString("d");

            return View(db.Guests.ToList());
        }

        [HttpGet]
        [Route("home/blank")]
        public ViewResult Blank()
        {
            return View();
        }

        [HttpPost]
        [Route("home/blank")]
        public ViewResult Blank(GuestResponse guestResponse)
        {
            // do zrobienia: wyślij zawartość guestResponse do organizatora przyjęcia
            if (ModelState.IsValid)
            {
                return View("BlankWithResponse", guestResponse);
            }
            else
            {
                return View();
            }
        }

        public ViewResult Contact()
        {
            return View();
        }
    }
}