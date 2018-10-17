using OnlineStore.App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStore.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult Register()
        {
            var newUser = new User();
            return View(newUser);
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            return View(user);
        }
    }
}