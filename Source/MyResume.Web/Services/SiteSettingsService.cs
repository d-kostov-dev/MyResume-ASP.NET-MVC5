using MyResume.Contracts;
using MyResume.Web.Services.Base;
using MyResume.Web.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyResume.Web.Services
{
    public class SiteSettingsService : BaseService, ISiteSettingsService
    {
        public SiteSettingsService(IDataProvider provider)
            : base(provider)
        {
        }
    }
}