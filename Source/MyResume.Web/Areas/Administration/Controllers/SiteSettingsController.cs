
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MyResume.Web.Areas.Administration.Models.InputModels;
using MyResume.Web.Services.Contracts;

namespace MyResume.Web.Areas.Administration.Controllers
{
    public class SiteSettingsController : AdminBaseController
    {
        private ISiteSettingsService services;

        public SiteSettingsController(ISiteSettingsService servicesProvider)
            : base(servicesProvider)
        {
            this.services = servicesProvider;
        }

        public ActionResult Index()
        {
            var itemsList = services.GetAllSettings();
            return View(itemsList);
        }

        public ActionResult Create()
        {
            return PartialView("CreateEditPartial");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AddEditSettingInputModel input)
        {
            if (ModelState.IsValid)
            {
                this.services.AddSetting(input);
            }

            return this.RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var model = this.services.GetSettingById(id);
            return PartialView("CreateEditPartial", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AddEditSettingInputModel input)
        {
            if (ModelState.IsValid)
            {
                this.services.SaveSetting(input);
            }

            return this.RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            this.services.DeleteSetting(id);
            return this.RedirectToAction("Index");
        }
    }
}