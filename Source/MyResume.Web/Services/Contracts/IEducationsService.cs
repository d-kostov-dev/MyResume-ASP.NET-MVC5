namespace MyResume.Web.Services.Contracts
{
    using System.Collections.Generic;

    using MyResume.Web.Areas.Administration.Models.InputModels;
    using MyResume.Web.Areas.Administration.Models.ViewModels;
    
    public interface IEducationsService : IBaseService
    {
        IEnumerable<EducationViewModel> GetAllEducations();

        AddEditEducationInputModel GetEducationById(int id);

        void AddEducation(AddEditEducationInputModel input);

        void SaveEducation(AddEditEducationInputModel input);

        void DeleteEducation(int id);
    }
}