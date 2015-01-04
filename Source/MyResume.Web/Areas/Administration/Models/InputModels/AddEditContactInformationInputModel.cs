namespace MyResume.Web.Areas.Administration.Models.InputModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using MyResume.Infrastructure.Mapping;
    using MyResume.Models;
    using MyResume.Web.Areas.Administration.Models.Base;
    
    public class AddEditContactInformationInputModel : BaseModel, IMapFrom<ContactInformation>
    {
        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string City { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime? BirthDate { get; set; }

        [StringLength(100, MinimumLength = 10)]
        public string LinkedIn { get; set; }

        [StringLength(100, MinimumLength = 10)]
        public string FaceBook { get; set; }

        [StringLength(20, MinimumLength = 3)]
        public string Skype { get; set; }
    }
}