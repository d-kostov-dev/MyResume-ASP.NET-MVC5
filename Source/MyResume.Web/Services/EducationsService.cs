namespace MyResume.Web.Services
{
    using MyResume.Contracts;
    using MyResume.Models;
    using MyResume.Web.Areas.Administration.Models.ViewModels;
    using MyResume.Web.Services.Base;
    using MyResume.Web.Services.Contracts;
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper.QueryableExtensions;
    using MyResume.Web.Areas.Administration.Models.InputModels;
    using AutoMapper;

    public class EducationsService : BaseService, IEducationsService
    {
        public EducationsService(IDataProvider provider)
            : base(provider)
        {
        }

        public IEnumerable<EducationViewModel> GetAllEducations()
        {
            return this.Data.Educations.All().OrderBy(x => x.Id).Project().To<EducationViewModel>();
        }

        public void AddEducation(AddEditEducationInputModel input)
        {
            var dbModel = Mapper.Map<Education>(input);

            this.Data.Educations.Add(dbModel);
            this.Data.SaveChanges();
        }


        public AddEditEducationInputModel GetEducationById(int id)
        {
            var dbResult = this.Data.Educations.All().Where(x => x.Id == id);
            return dbResult.Project().To<AddEditEducationInputModel>().FirstOrDefault();
        }


        public void SaveEducation(AddEditEducationInputModel input)
        {
            var dbModel = Mapper.Map<Education>(input);
            this.Data.Educations.Update(dbModel);
            this.Data.SaveChanges();
        }

        public void DeleteEducation(int id)
        {
            var itemToDelete = this.Data.Educations.Find(id);

            if (itemToDelete != null)
            {
                this.Data.Educations.Delete(itemToDelete);
                this.Data.SaveChanges();
            }
        }
    }
}