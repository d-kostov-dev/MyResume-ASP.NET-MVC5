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

    public class ContactInformationService : BaseService, IContactInformationService
    {
        public ContactInformationService(IDataProvider provider)
            : base(provider)
        {
        }

        public void Add(AddEditContactInformationInputModel input)
        {
            var dbModel = Mapper.Map<ContactInformation>(input);

            this.Data.ContactInformation.Add(dbModel);
            this.Data.SaveChanges();
        }

        public void Save(AddEditContactInformationInputModel input)
        {
            var dbModel = Mapper.Map<ContactInformation>(input);

            this.Data.ContactInformation.Update(dbModel);
            this.Data.SaveChanges();
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.Data.ContactInformation.All().OrderBy(x => x.Id).Project().To<T>();
        }

        public T GetById<T>(int id)
        {
            var dbResult = this.Data.ContactInformation.All().Where(x => x.Id == id);
            return dbResult.Project().To<T>().FirstOrDefault();
        }

        public void Delete(int id)
        {
            var itemToDelete = this.Data.ContactInformation.Find(id);

            if (itemToDelete != null)
            {
                this.Data.ContactInformation.Delete(itemToDelete);
                this.Data.SaveChanges();
            }
        }
    }
}