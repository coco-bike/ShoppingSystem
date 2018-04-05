using ShoppingSystem.Dal;
using ShoppingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //准备
            UserDal userDal = new UserDal();
            User user = new User()
            {
                Address = "asdasdsads",
                Email = "asdasdsadads",
                Name = "adsasdadsad",
                PassWord = "asdasd",
                RegisterTime = DateTime.Now,
                State = 1,
                Type = 1,
                UpdateTime = DateTime.Now
            };
            //动作
            var res = userDal.AddUser(user);
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
    }
}