
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
            return View();
        }

        public ActionResult Create()
        {
            return PartialView("CreatePartial");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AddSettingInputModel input)
        {
            return this.RedirectToAction("Index");
        }

        public ActionResult Edit()
        {
            return View();
        }
    }
}