using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyResume.Web.Areas.Administration.Controllers
{
    public class DashboardController : AdminBaseController
    {
        public ActionResult Index()
        {
            return this.View();
        }
    }
}