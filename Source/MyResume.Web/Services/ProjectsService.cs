namespace MyResume.Web.Services
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;
    using AutoMapper.QueryableExtensions;

    using MyResume.Contracts;
    using MyResume.Models;
    using MyResume.Web.Areas.Administration.Models.InputModels;
    using MyResume.Web.Services.Base;
    using MyResume.Web.Services.Contracts;
    
    public class ProjectsService : BaseService, IProjectsService
    {
        private IImagesService imageServices;

        public ProjectsService(IDataProvider provider, IImagesService imageServices)
            : base(provider)
        {
            this.imageServices = imageServices;
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.Data.Projects.All().OrderBy(x => x.Id).Project().To<T>();
        }

        public T GetById<T>(int id)
        {
            var dbResult = this.Data.Projects.All().Where(x => x.Id == id);
            return dbResult.Project().To<T>().FirstOrDefault();
        }

        public void Add(AddEditProjectInputModel input)
        {
            var dbModel = Mapper.Map<Project>(input);

            if (input.FileUploaded != null)
            {
                dbModel.ImageId = imageServices.Save(input.FileUploaded);
            }

            this.Data.Projects.Add(dbModel);
            this.Data.SaveChanges();
        }

        public void Save(AddEditProjectInputModel input)
        {
            var dbModel = Mapper.Map<Project>(input);

            if (input.FileUploaded != null)
            {
                // Delete the old image
                if (dbModel.ImageId != null)
                {
                    imageServices.Delete(dbModel.ImageId.Value);
                }

                dbModel.ImageId = imageServices.Save(input.FileUploaded);
            }

            this.Data.Projects.Update(dbModel);
            this.Data.SaveChanges();
        }

        public void Delete(int id)
        {
            var itemToDelete = this.Data.Projects.Find(id);

            if (itemToDelete != null)
            {
                this.Data.Images.Delete(this.Data.Images.Find(itemToDelete.ImageId));
                this.Data.Projects.Delete(itemToDelete);
                this.Data.SaveChanges();
            }
        }
    }
}