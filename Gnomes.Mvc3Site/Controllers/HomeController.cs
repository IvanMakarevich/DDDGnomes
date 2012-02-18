using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gnomes.Domain;

namespace Gnomes.Mvc3Site.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            using (GnomesContext context = new GnomesContext())
            {
                var t = context.Gnomes.ToList();
            }
            return View();
        }
    }
}
