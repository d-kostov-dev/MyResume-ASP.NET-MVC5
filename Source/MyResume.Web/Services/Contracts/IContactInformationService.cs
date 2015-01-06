namespace MyResume.Web.Services.Contracts
{
    using MyResume.Web.Areas.Administration.Models.InputModels;
using MyResume.Web.Areas.Administration.Models.ViewModels;

    public interface IContactInformationService : IBaseService, ICommonOperationsService
    {
        ContactInformationViewModel GetFirst();

        void Add(AddEditContactInformationInputModel input);

        void Save(AddEditContactInformationInputModel input);
    }
}