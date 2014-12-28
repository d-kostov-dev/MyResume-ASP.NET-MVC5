namespace MyResume.Web.Areas.Administration.Models.InputModels
{
    using System.ComponentModel.DataAnnotations;

    using MyResume.Models;
    using MyResume.Infrastructure.Mapping;
    using MyResume.Web.Areas.Administration.Models.Base;
    using System.Web;

    public class AddEditEducationInputModel : BaseModel,  IMapFrom<Education>
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string School { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Field { get; set; }

        [StringLength(50, MinimumLength = 2)]
        public string Degree { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int FromYear { get; set; }

        public int ToYear { get; set; }

        public string SchoolSite { get; set; }

        public HttpPostedFileBase Image { get; set; }
    }
}