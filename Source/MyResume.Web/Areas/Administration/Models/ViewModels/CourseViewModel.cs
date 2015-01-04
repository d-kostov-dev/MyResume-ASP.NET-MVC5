namespace MyResume.Web.Areas.Administration.Models.ViewModels
{
    using MyResume.Infrastructure.Mapping;
    using MyResume.Models;
    using MyResume.Web.Areas.Administration.Models.Base;

    public class CourseViewModel : BaseModel, IMapFrom<Course>
    {
        public string Name { get; set; }

        public string Institution { get; set; }

        public string Description { get; set; }

        public int FromYear { get; set; }

        public int ToYear { get; set; }
    }
}