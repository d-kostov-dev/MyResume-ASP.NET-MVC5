namespace MyResume.Web.Services.Contracts
{
    using System.Collections.Generic;

    using MyResume.Web.Areas.Administration.Models.ViewModels;
    using MyResume.Web.Areas.Administration.Models.InputModels;

    public interface ISiteSettingsService : IBaseService, ICommonOperationsService
    {
        void Add(AddEditSettingInputModel input);

        void Save(AddEditSettingInputModel input);
    }
}