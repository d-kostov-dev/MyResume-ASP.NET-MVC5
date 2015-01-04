namespace MyResume.Web.Services.Contracts
{
    using MyResume.Web.Areas.Administration.Models.InputModels;

    public interface IProjectsService : IBaseService, ICommonOperationsService
    {

        void Add(AddEditProjectInputModel input);

        void Save(AddEditProjectInputModel input);
    }
}