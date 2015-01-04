namespace MyResume.Web.Areas.Administration.Models.ViewModels
{
    using MyResume.Infrastructure.Mapping;
    using MyResume.Models;
    using MyResume.Web.Areas.Administration.Models.Base;

    public class ProjectViewModel : BaseModel, IMapFrom<Project>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string URL { get; set; }

        public int? ImageId { get; set; }
    }
}