namespace MyResume.Web.Areas.Administration.Models.InputModels
{
    using System.ComponentModel.DataAnnotations;

    using MyResume.Infrastructure.Mapping;
    using MyResume.Models;
    using MyResume.Web.Areas.Administration.Models.Base;
    using System.Web.Mvc;

    public class AddEditExperienceInputModel : ImagedModel, IMapFrom<Experience>
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        [Display(Name="Company Name")]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }

        public string Location { get; set; }

        [StringLength(1000)]
        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string Description { get; set; }

        [Display(Name = "From Year")]
        public int FromYear { get; set; }

        [Display(Name = "To Year")]
        public int ToYear { get; set; }

        [Display(Name = "Company Site")]
        public string CompanySite { get; set; }
    }
}