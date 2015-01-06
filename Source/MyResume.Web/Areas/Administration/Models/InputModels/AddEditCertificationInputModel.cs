namespace MyResume.Web.Areas.Administration.Models.InputModels
{
    using System.Web;
    using System.ComponentModel.DataAnnotations;

    using MyResume.Infrastructure.Mapping;
    using MyResume.Models;
    using MyResume.Web.Areas.Administration.Models.Base;
    using System.Web.Mvc;
    
    public class AddEditCertificationInputModel : ImagedModel, IMapFrom<Certificate>
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Title { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Institution { get; set; }

        [StringLength(1000)]
        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string Description { get; set; }

        public int IssueYear { get; set; }

        public string InstitutionSite { get; set; }
    }
}