using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gnomes.Application.Contracts;
using Microsoft.Practices.ServiceLocation;

namespace Gnomes.Mvc3Site.Controllers
{
    public abstract class BaseController : Controller
    {
        private ISeedService _seedService;

        protected ISeedService SeedService
        {
            get { return _seedService ?? (_seedService = ServiceLocator.Current.GetInstance<ISeedService>()); }
        }

        private IGnomeService _gnomeService;

        public IGnomeService GnomeService
        {
            get { return _gnomeService ?? (_gnomeService = ServiceLocator.Current.GetInstance<IGnomeService>()); }
        }
    }
}