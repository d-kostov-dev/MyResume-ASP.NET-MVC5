namespace MyResume.Web.Areas.Administration.Models.InputModels
{
    using System.ComponentModel.DataAnnotations;

    using MyResume.Infrastructure.Mapping;
    using MyResume.Models;
    using MyResume.Web.Areas.Administration.Models.Base;
    using System.Web.Mvc;

    public class AddEditProjectInputModel : ImagedModel, IMapFrom<Project>
    {

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [StringLength(1000)]
        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string Description { get; set; }

        public string URL { get; set; }
    }
}