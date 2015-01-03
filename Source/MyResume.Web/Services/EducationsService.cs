namespace MyResume.Web.Services
{
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

    public class EducationsService : BaseService, IEducationsService
    {
        private IImagesService imageServices;

        public EducationsService(IDataProvider provider, IImagesService imageServices)
            : base(provider)
        {
            this.imageServices = imageServices;
        }

        public IEnumerable<EducationViewModel> GetAllEducations()
        {
            return this.Data.Educations.All().OrderBy(x => x.Id).Project().To<EducationViewModel>();
        }

        public void AddEducation(AddEditEducationInputModel input)
        {
            var dbModel = Mapper.Map<Education>(input);

            if (input.FileUploaded != null)
            {
                dbModel.ImageId = imageServices.SaveImage(input.FileUploaded);
            }

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

            if (input.FileUploaded != null)
            {
                // Delete the old image
                if (dbModel.ImageId != null)
                {
                    imageServices.DeleteImage(dbModel.ImageId.Value);
                }

                dbModel.ImageId = imageServices.SaveImage(input.FileUploaded);
            }

            this.Data.Educations.Update(dbModel);
            this.Data.SaveChanges();
        }

        public void DeleteEducation(int id)
        {
            var itemToDelete = this.Data.Educations.Find(id);

            if (itemToDelete != null)
            {
                this.Data.Images.Delete(this.Data.Images.Find(itemToDelete.ImageId));
                this.Data.Educations.Delete(itemToDelete);
                this.Data.SaveChanges();
            }
        }
    }
}