namespace MyResume.Web.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;
    using AutoMapper.QueryableExtensions;

    using MyResume.Contracts;
    using MyResume.Models;
    using MyResume.Web.Areas.Administration.Models.InputModels;
    using MyResume.Web.Areas.Administration.Models.ViewModels;
    using MyResume.Web.Services.Base;
    using MyResume.Web.Services.Contracts;

    public class SiteSettingsService : BaseService, ISiteSettingsService
    {
        public SiteSettingsService(IDataProvider provider)
            : base(provider)
        {
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.Data.SiteSettings.All().OrderBy(x => x.Id).Project().To<T>();
        }

        public T GetById<T>(int id)
        {
            var dbResult = this.Data.SiteSettings.All().Where(x => x.Id == id);
            return dbResult.Project().To<T>().FirstOrDefault();
        }


        public void Add(AddEditSettingInputModel input)
        {
            var dbModel = Mapper.Map<SiteSetting>(input);

            this.Data.SiteSettings.Add(dbModel);
            this.Data.SaveChanges();
        }

        public void Save(AddEditSettingInputModel input)
        {
            var dbModel = Mapper.Map<SiteSetting>(input);

            var settingToEdit = this.Data.SiteSettings.Find(dbModel.Id);

            if (settingToEdit != null)
            {
                settingToEdit.Value = input.Value;
                settingToEdit.ModifiedOn = DateTime.Now;
                settingToEdit.Description = input.Description;

                this.Data.SaveChanges();
            }
        }


        public void Delete(int id)
        {
            var settingToDelete = this.Data.SiteSettings.Find(id);

            if (settingToDelete != null)
            {
                this.Data.SiteSettings.Delete(settingToDelete);
                this.Data.SaveChanges();
            }
        }
    }
}