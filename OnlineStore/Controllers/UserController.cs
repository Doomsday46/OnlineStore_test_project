using AutoMapper;
using Ninject;
using OnlineStore.App_Data;
using OnlineStore.Models;
using System.Linq;
using System.Web.Mvc;

namespace OnlineStore.Controllers
{
    public class UserController : Controller
    {

        [Inject]
        public IRepository Repository { get; set; }

        [Inject]
        public IMapper ModelMapper { get; set; }
        // GET: User
        [HttpGet]
        public ActionResult Register()
        {
            var newUserView = new UserView();
            return View(newUserView);
        }

        [HttpPost]
        public ActionResult Register(UserView userView)
        {
            if (userView.Captcha != "1234")
            {
                ModelState.AddModelError("Captcha", "Текст с картинки введен неверно");
            }
            var anyUser = Repository.Users.Any(p => string.Compare(p.Email, userView.Email) == 0);
            if (anyUser)
            {
                ModelState.AddModelError("Email", "Пользователь с таким email уже зарегистрирован");
            }

            if (ModelState.IsValid)
            {
                var user = (User)ModelMapper.Map(userView, typeof(UserView), typeof(User));
                //TODO: Сохранить
            }
            return View(userView);
        }
    }
}