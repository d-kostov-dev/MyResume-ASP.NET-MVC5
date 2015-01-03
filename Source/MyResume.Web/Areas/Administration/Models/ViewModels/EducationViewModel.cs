namespace MyResume.Web.Areas.Administration.Models.ViewModels
{
    using MyResume.Web.Areas.Administration.Models.Base;
    using MyResume.Models;
    using MyResume.Infrastructure.Mapping;

    public class EducationViewModel : BaseModel, IMapFrom<Education>
    {
        public int Id { get; set; }

        public string School { get; set; }

        public string Field { get; set; }

        public string Degree { get; set; }

        public string Description { get; set; }

        public int FromYear { get; set; }

        public int ToYear { get; set; }

        public int? ImageId { get; set; }

        public string SchoolSite { get; set; }
    }
}