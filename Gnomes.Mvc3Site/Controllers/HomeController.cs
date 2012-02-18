using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gnomes.Domain;
using Gnomes.Domain.Entities;

namespace Gnomes.Mvc3Site.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            Gnome gnome = GnomeService.LoadGnomeById(1);
            GnomeAction firstAction = gnome.GnomeActions.FirstOrDefault(a => a.PreviousAction == null);
            ViewBag.FirstAction = firstAction;

            return View(gnome);
        }

        public ActionResult About2()
        {
            Gnome gnome = GnomeService.LoadGnomeById(1);
            GnomeAction firstAction = gnome.GnomeActions.FirstOrDefault(a => a.PreviousAction == null);
            ViewBag.FirstAction = firstAction;

            return View(gnome);
        }
    }
}
