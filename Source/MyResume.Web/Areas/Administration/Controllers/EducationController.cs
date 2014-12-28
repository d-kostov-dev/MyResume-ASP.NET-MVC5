namespace MyResume.Web.Areas.Administration.Controllers
{
    using MyResume.Web.Services.Contracts;
    using System.Web.Mvc;

    public class EducationController : AdminBaseController
    {
        private IEducationsService dataProvider;

        public EducationController(IEducationsService provider)
            : base(provider)
        {
            this.dataProvider = provider;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}