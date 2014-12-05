using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyResume.Web.Areas.Administration.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Administration/Projects
        public ActionResult Index()
        {
            return View();
        }
    }
}