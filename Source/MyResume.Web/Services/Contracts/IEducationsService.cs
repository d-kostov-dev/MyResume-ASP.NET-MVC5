namespace MyResume.Web.Services.Contracts
{
    using System.Collections.Generic;

    using MyResume.Web.Areas.Administration.Models.InputModels;
    using MyResume.Web.Areas.Administration.Models.ViewModels;

    public interface IEducationsService : IBaseService, ICommonOperationsService
    {
        void Add(AddEditEducationInputModel input);

        void Save(AddEditEducationInputModel input);
    }
}