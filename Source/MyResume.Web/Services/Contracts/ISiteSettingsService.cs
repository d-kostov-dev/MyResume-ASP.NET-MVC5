namespace MyResume.Web.Services.Contracts
{
    using System.Collections.Generic;
    using MyResume.Web.Areas.Administration.Models.ViewModels;
    using MyResume.Web.Areas.Administration.Models.InputModels;

    public interface ISiteSettingsService : IBaseService
    {
        IEnumerable<SiteSettingsViewModel> GetAllSettings();

        AddEditSettingInputModel GetSettingById(int id);

        void AddSetting(AddEditSettingInputModel input);

        void SaveSetting(AddEditSettingInputModel input);

        void DeleteSetting(int id);
    }
}