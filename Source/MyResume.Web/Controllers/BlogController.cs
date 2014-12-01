namespace MyResume.Web.Controllers
{
    using System.Web.Mvc;

    public class BlogController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }
    }
}