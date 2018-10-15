using OnlineStore.Models;
using OnlineStore.Models.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStore.Controllers
{
    public class HomeController : Controller
    {
        PhoneContext phoneContext = new PhoneContext();

        public ActionResult Index()
        {
            IEnumerable<Phone> phones = phoneContext.Phones;

            ViewBag.Phones = phones;

            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id) {

            ViewBag.Id = id;

            return View();
        }

        [HttpPost]
        public string Buy(Purchase purchase) {
            purchase.DateTime = DateTime.Now;

            phoneContext.Purchases.Add(purchase);

            phoneContext.SaveChanges();

            return $"Ok, 200";
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