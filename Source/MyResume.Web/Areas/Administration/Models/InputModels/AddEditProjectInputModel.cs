namespace MyResume.Web.Areas.Administration.Models.InputModels
{
    using System.ComponentModel.DataAnnotations;

    using MyResume.Infrastructure.Mapping;
    using MyResume.Models;
    using MyResume.Web.Areas.Administration.Models.Base;

    public class AddEditProjectInputModel : ImagedModel, IMapFrom<Project>
    {

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public string URL { get; set; }
    }
}