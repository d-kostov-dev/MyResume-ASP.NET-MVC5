namespace MyResume.Web.Areas.Administration.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using MyResume.Web.Areas.Administration.Models.InputModels;
    using MyResume.Web.Services.Contracts;

    public class SiteSettingsController : AdminBaseController
    {
        private ISiteSettingsService dataProvider;

        public SiteSettingsController(ISiteSettingsService provider)
            : base(provider)
        {
            this.dataProvider = provider;
        }

        public ActionResult Index()
        {
            var itemsList = this.dataProvider.GetAllSettings();
            return View(itemsList);
        }

        public ActionResult Create()
        {
            return this.PartialView("CreateEditPartial");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AddEditSettingInputModel input)
        {
            if (ModelState.IsValid)
            {
                this.dataProvider.AddSetting(input);
            }

            return this.RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var model = this.dataProvider.GetSettingById(id);
            return this.PartialView("CreateEditPartial", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AddEditSettingInputModel input)
        {
            if (ModelState.IsValid)
            {
                this.dataProvider.SaveSetting(input);
            }

            return this.RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            this.dataProvider.DeleteSetting(id);
            return this.RedirectToAction("Index");
        }
    }
}