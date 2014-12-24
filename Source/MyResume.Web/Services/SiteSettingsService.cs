using MyResume.Contracts;
using MyResume.Web.Areas.Administration.Models.ViewModels;
using MyResume.Web.Services.Base;
using MyResume.Web.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper.QueryableExtensions;

namespace MyResume.Web.Services
{
    public class SiteSettingsService : BaseService, ISiteSettingsService
    {
        public SiteSettingsService(IDataProvider provider)
            : base(provider)
        {
        }

        public IEnumerable<SiteSettingsViewModel> GetAll()
        {
            return this.Data.SiteSettings.All().Project().To<SiteSettingsViewModel>();
        }
    }
}