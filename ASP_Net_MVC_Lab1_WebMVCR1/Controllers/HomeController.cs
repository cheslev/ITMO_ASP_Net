using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_Net_MVC_Lab1_WebMVCR1.Models;

namespace ASP_Net_MVC_Lab1_WebMVCR1.Controllers
{
    public class MyController : Controller
    {
        private static PersonRepository db = new PersonRepository();
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброе утро" :
            "Добрый день";
            ViewData["Mes"] = "хорошего настроения";
            return View();
        }
        [HttpGet]
        public ViewResult InputData()
        {
            return View();
        }

        [HttpPost]
        public ViewResult InputData(Person p)
        {
            db.AddResponse(p);
            return View("Hello", p);
        }

        public ViewResult OutputData()
        {
            ViewBag.Pers = db.GetAllResponses;
            ViewBag.Count = db.NumberOfPerson;
            return View("ListPerson");
        }
        // GET: Home
        //public string Index(string hel)
        // {
        //  string Greeting = ModelClass.ModelHello() + ", " + hel;
        //  return Greeting;
        //  }
    }
}