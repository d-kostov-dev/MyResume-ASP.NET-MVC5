namespace MyResume.Web.Services.Contracts
{
    using MyResume.Web.Areas.Administration.Models.InputModels;

    public interface ICoursesService : IBaseService, ICommonOperationsService
    {
        void Add(AddEditCourseInputModel input);

        void Save(AddEditCourseInputModel input);
    }
}