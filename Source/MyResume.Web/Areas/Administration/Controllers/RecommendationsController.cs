using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyResume.Web.Areas.Administration.Controllers
{
    public class RecommendationsController : Controller
    {
        // GET: Administration/Recommendations
        public ActionResult Index()
        {
            return View();
        }
    }
}