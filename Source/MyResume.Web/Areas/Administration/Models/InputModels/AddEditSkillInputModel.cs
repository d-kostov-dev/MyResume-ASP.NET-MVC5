namespace MyResume.Web.Areas.Administration.Models.InputModels
{
    using System.ComponentModel.DataAnnotations;
    using System.Web;

    using MyResume.Infrastructure.Mapping;
    using MyResume.Models;
    using MyResume.Web.Areas.Administration.Models.Base;

    public class AddEditSkillInputModel : ImagedModel, IMapFrom<Skill>
    {
        [Required]
        [StringLength(20, MinimumLength = 1)]
        public string Name { get; set; }

        [StringLength(1000)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public int Level { get; set; }

        public int YearsOfExperience { get; set; }
    }
}