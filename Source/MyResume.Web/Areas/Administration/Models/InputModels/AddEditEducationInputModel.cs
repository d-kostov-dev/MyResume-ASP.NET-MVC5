namespace MyResume.Web.Areas.Administration.Models.InputModels
{
    using System.ComponentModel.DataAnnotations;
    using System.Web;

    using MyResume.Infrastructure.Mapping;
    using MyResume.Models;
    using MyResume.Web.Areas.Administration.Models.Base;

    public class AddEditEducationInputModel : ImagedModel, IMapFrom<Education>
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string School { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Field { get; set; }

        [StringLength(50, MinimumLength = 2)]
        public string Degree { get; set; }

        [StringLength(1000)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "From Year")]
        public int FromYear { get; set; }

        [Display(Name = "To Year")]
        public int ToYear { get; set; }

        [Display(Name = "School Site URL")]
        public string SchoolSite { get; set; }
    }
}