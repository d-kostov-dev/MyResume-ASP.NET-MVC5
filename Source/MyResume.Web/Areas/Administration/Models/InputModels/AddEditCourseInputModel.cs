namespace MyResume.Web.Areas.Administration.Models.InputModels
{
    using System.ComponentModel.DataAnnotations;

    using MyResume.Infrastructure.Mapping;
    using MyResume.Models;
    using MyResume.Web.Areas.Administration.Models.Base;
    
    public class AddEditCourseInputModel : BaseModel, IMapFrom<Course>
    {
        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string Institution { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int FromYear { get; set; }

        public int ToYear { get; set; }
    }
}