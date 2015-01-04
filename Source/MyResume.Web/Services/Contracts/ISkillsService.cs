namespace MyResume.Web.Services.Contracts
{
    using System.Collections.Generic;

    using MyResume.Web.Areas.Administration.Models.InputModels;
    using MyResume.Web.Areas.Administration.Models.ViewModels;

    public interface ISkillsService : IBaseService, ICommonOperationsService
    {
        void Add(AddEditSkillInputModel input);

        void Save(AddEditSkillInputModel input);
    }
}