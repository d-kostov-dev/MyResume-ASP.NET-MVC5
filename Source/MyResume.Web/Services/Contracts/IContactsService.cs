namespace MyResume.Web.Services.Contracts
{
    using MyResume.Web.Models.InputModels;

    public interface IContactsService : IBaseService
    {
        void Add(ContactInputModel input);
    }
}