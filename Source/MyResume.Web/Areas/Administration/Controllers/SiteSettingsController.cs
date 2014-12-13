﻿using MyResume.Web.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
    }
}