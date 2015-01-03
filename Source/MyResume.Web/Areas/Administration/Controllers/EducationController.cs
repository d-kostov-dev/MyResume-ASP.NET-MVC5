namespace MyResume.Web.Areas.Administration.Controllers
{
    using MyResume.Web.Areas.Administration.Models.InputModels;
    using MyResume.Web.Services.Contracts;
    using System.Web;
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
            var itemsList = this.dataProvider.GetAllEducations();
            return View(itemsList);
        }

        public ActionResult Create()
        {
            return this.PartialView("CreateEditPartial");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AddEditEducationInputModel input)
        {
            if (ModelState.IsValid)
            {
                this.dataProvider.AddEducation(input);
            }

            return this.RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var model = this.dataProvider.GetEducationById(id);
            return this.PartialView("CreateEditPartial", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AddEditEducationInputModel input)
        {
            if (ModelState.IsValid)
            {
                this.dataProvider.SaveEducation(input);
            }

            return this.RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            this.dataProvider.DeleteEducation(id);
            return this.RedirectToAction("Index");
        }
    }
}