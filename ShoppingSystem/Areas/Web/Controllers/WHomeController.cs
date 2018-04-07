using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingSystem.Areas.Web.Controllers
{
    public class WHomeController : Controller
    {
        // GET: Web/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}