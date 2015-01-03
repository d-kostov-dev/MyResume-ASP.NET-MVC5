namespace MyResume.Web.Services.Contracts
{
    using MyResume.Models;
using System.Web;

    public interface IImagesService : IBaseService
    {
        Image GetImageById(int id);

        int SaveImage(HttpPostedFileBase image);

        void DeleteImage(int id);
    }
}