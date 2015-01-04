namespace MyResume.Web.Areas.Administration.Models.ViewModels
{
    using MyResume.Infrastructure.Mapping;
    using MyResume.Models;
    using MyResume.Web.Areas.Administration.Models.Base;

    public class SkillViewModel : BaseModel, IMapFrom<Skill>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Level { get; set; }

        public int YearsOfExperience { get; set; }

        public int? ImageId { get; set; }
    }
}