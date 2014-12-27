namespace MyResume.Web.Areas.Administration.Models.ViewModels
{
    using MyResume.Infrastructure.Mapping;
    using MyResume.Models;
    using MyResume.Web.Areas.Administration.Models.Base;

    public class SiteSettingsViewModel : BaseModel, IMapFrom<SiteSetting>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public string Description { get; set; }
    }
}