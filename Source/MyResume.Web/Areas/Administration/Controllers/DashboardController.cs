namespace MyResume.Web.Areas.Administration.Controllers
{
    using System.Web.Mvc;

    public class DashboardController : AdminBaseController
    {
        public ActionResult Index()
        {
            return this.View();
        }
    }
}