namespace MyResume.Web.Controllers
{
    using System.Web.Mvc;

    public class ContactsController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }
    }
}