using MyResume.Web.Areas.Administration.Models.ViewModels;
using System.Collections.Generic;

namespace MyResume.Web.Services.Contracts
{
    public interface ISiteSettingsService : IBaseService
    {
        IEnumerable<SiteSettingsViewModel> GetAll();
    }
}