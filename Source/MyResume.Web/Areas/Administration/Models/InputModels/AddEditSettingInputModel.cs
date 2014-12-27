namespace MyResume.Web.Areas.Administration.Models.InputModels
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using MyResume.Web.Areas.Administration.Models.Base;
    using MyResume.Models;
    using MyResume.Infrastructure.Mapping;

    public class AddEditSettingInputModel : BaseModel, IMapFrom<SiteSetting>
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        [Required]
        public string Value { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 10)]
        public string Description { get; set; }
    }
}