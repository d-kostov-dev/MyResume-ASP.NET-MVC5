namespace MyResume.Web.Services.Contracts
{
    using MyResume.Models;
    using System.Web;

    public interface IImagesService : IBaseService
    {
        Image GetById(int id);

        int Save(HttpPostedFileBase image);

        void Delete(int id);
    }
}