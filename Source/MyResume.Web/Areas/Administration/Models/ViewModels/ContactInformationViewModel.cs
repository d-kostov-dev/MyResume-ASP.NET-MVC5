namespace MyResume.Web.Areas.Administration.Models.ViewModels
{
    using System;

    using MyResume.Infrastructure.Mapping;
    using MyResume.Models;
    using MyResume.Web.Areas.Administration.Models.Base;
    
    public class ContactInformationViewModel : BaseModel, IMapFrom<ContactInformation>
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string City { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime? BirthDate { get; set; }

        public string LinkedIn { get; set; }

        public string FaceBook { get; set; }

        public string Skype { get; set; }
    }
}