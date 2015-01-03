using MyResume.Web.Areas.Administration.Models.InputModels;
using MyResume.Web.Areas.Administration.Models.ViewModels;
using System.Collections.Generic;
namespace MyResume.Web.Services.Contracts
{
    public interface IEducationsService : IBaseService
    {
        IEnumerable<EducationViewModel> GetAllEducations();

        AddEditEducationInputModel GetEducationById(int id);

        void AddEducation(AddEditEducationInputModel input);

        void SaveEducation(AddEditEducationInputModel input);

        void DeleteSetting(int id);
    }
}