namespace MyResume.Web.Services.Contracts
{
    using MyResume.Web.Areas.Administration.Models.InputModels;

    public interface IContactInformationService : IBaseService, ICommonOperationsService
    {
        void Add(AddEditContactInformationInputModel input);

        void Save(AddEditContactInformationInputModel input);
    }
}