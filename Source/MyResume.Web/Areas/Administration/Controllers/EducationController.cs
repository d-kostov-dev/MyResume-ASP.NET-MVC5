namespace MyResume.Web.Areas.Administration.Controllers
{
    using System.Web.Mvc;

    using MyResume.Web.Services.Contracts;
    
    using InputModel = MyResume.Web.Areas.Administration.Models.InputModels.AddEditEducationInputModel;
    using ViewModel = MyResume.Web.Areas.Administration.Models.ViewModels.EducationViewModel;

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
            var itemsList = this.dataProvider.GetAll<ViewModel>();
            return View(itemsList);
        }

        public ActionResult Create()
        {
            return this.PartialView("CreateEditPartial");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(InputModel input)
        {
            if (ModelState.IsValid)
            {
                this.dataProvider.Add(input);
            }

            return this.RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var model = this.dataProvider.GetById<InputModel>(id);
            return this.PartialView("CreateEditPartial", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(InputModel input)
        {
            if (ModelState.IsValid)
            {
                this.dataProvider.Save(input);
            }

            return this.RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            this.dataProvider.Delete(id);
            return this.RedirectToAction("Index");
        }
    }
}