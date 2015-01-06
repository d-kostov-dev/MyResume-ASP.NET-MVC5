namespace MyResume.Web.Models.InputModels
{
    using MyResume.Infrastructure.Mapping;
    using MyResume.Models;
    using MyResume.Web.Areas.Administration.Models.Base;
    using System.ComponentModel.DataAnnotations;

    public class ContactInputModel : BaseModel, IMapFrom<Contact>
    {
        [Required]
        public string From { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
    }
}