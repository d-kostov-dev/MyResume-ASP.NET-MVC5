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
    
    public class CertificationsService : BaseService, ICertificationsService
    {
        private IImagesService imageServices;

        public CertificationsService(IDataProvider provider, IImagesService imageServices)
            : base(provider)
        {
            this.imageServices = imageServices;
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.Data.Certificates.All().OrderBy(x => x.Id).Project().To<T>();
        }

        public T GetById<T>(int id)
        {
            var dbResult = this.Data.Certificates.All().Where(x => x.Id == id);
            return dbResult.Project().To<T>().FirstOrDefault();
        }

        public void Add(AddEditCertificationInputModel input)
        {
            var dbModel = Mapper.Map<Certificate>(input);

            if (input.FileUploaded != null)
            {
                dbModel.ImageId = imageServices.Save(input.FileUploaded);
            }

            this.Data.Certificates.Add(dbModel);
            this.Data.SaveChanges();
        }

        public void Save(AddEditCertificationInputModel input)
        {
            var dbModel = Mapper.Map<Certificate>(input);

            if (input.FileUploaded != null)
            {
                // Delete the old image
                if (dbModel.ImageId != null)
                {
                    imageServices.Delete(dbModel.ImageId.Value);
                }

                dbModel.ImageId = imageServices.Save(input.FileUploaded);
            }

            this.Data.Certificates.Update(dbModel);
            this.Data.SaveChanges();
        }

        public void Delete(int id)
        {
            var itemToDelete = this.Data.Certificates.Find(id);

            if (itemToDelete != null)
            {
                this.Data.Images.Delete(this.Data.Images.Find(itemToDelete.ImageId));
                this.Data.Certificates.Delete(itemToDelete);
                this.Data.SaveChanges();
            }
        }
    }
}