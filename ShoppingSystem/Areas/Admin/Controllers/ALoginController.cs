using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingSystem.Areas.Admin.Controllers
{
    public class ALoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Login()
        {
            return View();
        }
    }
}