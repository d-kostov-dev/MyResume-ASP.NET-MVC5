namespace MyResume.Web.Areas.Administration.Controllers
{
    using System.Web.Mvc;

    using MyResume.Web.Services.Contracts;
    
    public class DashboardController : AdminBaseController
    {
        private IDashboardService services;

        public DashboardController(IDashboardService servicesProvider)
            : base(servicesProvider)
        {
            this.services = servicesProvider;
        }

        public ActionResult Index()
        {
            return this.View();
        }
    }
}