namespace MyResume.Web.Services.Contracts
{
    using MyResume.Web.Areas.Administration.Models.InputModels;

    public interface IExperiencesService : IBaseService, ICommonOperationsService
    {
        void Add(AddEditExperienceInputModel input);

        void Save(AddEditExperienceInputModel input);
    }
}