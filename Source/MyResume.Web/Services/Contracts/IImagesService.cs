namespace MyResume.Web.Services.Contracts
{
    using MyResume.Models;

    public interface IImagesService : IBaseService
    {
        Image GetImageById(int id);
    }
}