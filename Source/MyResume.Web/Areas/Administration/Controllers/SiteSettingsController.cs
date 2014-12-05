using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyResume.Web.Areas.Administration.Controllers
{
    public class SiteSettingsController : Controller
    {
        // GET: Administration/SiteSettings
        public ActionResult Index()
        {
            return View();
        }
    }
}