using MyResume.Infrastructure.Mapping;
using MyResume.Models;
using AutoMapper;

namespace MyResume.Web.Areas.Administration.Models.ViewModels
{
    public class SiteSettingsViewModel : IMapFrom<SiteSetting>
    {
        public string Name { get; set; }
    }
}