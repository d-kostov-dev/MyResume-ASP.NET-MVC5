namespace MyResume.Web.Controllers
{
    using System.Web.Mvc;

    using MyResume.Web.Models.InputModels;
    using MyResume.Web.Services.Contracts;
    
    public class ContactsController : Controller
    {
        private IContactsService serviceProvider;

        public ContactsController(IContactsService provider)
        {
            this.serviceProvider = provider;
        }

        public ActionResult Index()
        {
            return this.View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ContactInputModel input)
        {
            this.serviceProvider.Add(input);
            return this.RedirectToAction("Index", "Home");
        }
    }
}