namespace MyResume.Web.Areas.Administration.Models.ViewModels
{
    using MyResume.Infrastructure.Mapping;
    using MyResume.Models;
    using MyResume.Web.Areas.Administration.Models.Base;

    public class ExperienceViewModel : BaseModel, IMapFrom<Experience>
    {
        public string CompanyName { get; set; }

        public string JobTitle { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public int FromYear { get; set; }

        public int ToYear { get; set; }

        public string CompanySite { get; set; }

        public int? ImageId { get; set; }
    }
}