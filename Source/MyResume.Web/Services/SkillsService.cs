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
    
    public class SkillsService : BaseService, ISkillsService
    {
        private IImagesService imageServices;

        public SkillsService(IDataProvider provider, IImagesService imageServices)
            : base(provider)
        {
            this.imageServices = imageServices;
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.Data.Skills.All().OrderBy(x => x.Id).Project().To<T>();
        }

        public T GetById<T>(int id)
        {
            var dbResult = this.Data.Skills.All().Where(x => x.Id == id);
            return dbResult.Project().To<T>().FirstOrDefault();
        }

        public void Add(AddEditSkillInputModel input)
        {
            var dbModel = Mapper.Map<Skill>(input);

            if (input.FileUploaded != null)
            {
                dbModel.ImageId = imageServices.Save(input.FileUploaded);
            }

            this.Data.Skills.Add(dbModel);
            this.Data.SaveChanges();
        }

        public void Save(AddEditSkillInputModel input)
        {
            var dbModel = Mapper.Map<Skill>(input);

            if (input.FileUploaded != null)
            {
                // Delete the old image
                if (dbModel.ImageId != null)
                {
                    imageServices.Delete(dbModel.ImageId.Value);
                }

                dbModel.ImageId = imageServices.Save(input.FileUploaded);
            }

            this.Data.Skills.Update(dbModel);
            this.Data.SaveChanges();
        }

        public void Delete(int id)
        {
            var itemToDelete = this.Data.Skills.Find(id);

            if (itemToDelete != null)
            {
                this.Data.Images.Delete(this.Data.Images.Find(itemToDelete.ImageId));
                this.Data.Skills.Delete(itemToDelete);
                this.Data.SaveChanges();
            }
        }
    }
}