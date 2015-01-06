namespace MyResume.Web.Services
{
    using AutoMapper;

    using MyResume.Contracts;
    using MyResume.Models;
    using MyResume.Web.Models.InputModels;
    using MyResume.Web.Services.Base;
    using MyResume.Web.Services.Contracts;

    public class ContactsService : BaseService, IContactsService
    {
        public ContactsService(IDataProvider provider)
            : base(provider)
        {
        }

        public void Add(ContactInputModel input)
        {
            var dbModel = Mapper.Map<Contact>(input);

            this.Data.Contacts.Add(dbModel);
            this.Data.SaveChanges();
        }
    }
}