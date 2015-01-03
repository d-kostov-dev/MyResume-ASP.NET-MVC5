namespace MyResume.Web.Services
{
    using MyResume.Contracts;
    using MyResume.Models;
    using MyResume.Web.Services.Base;
    using MyResume.Web.Services.Contracts;

    public class ImagesService: BaseService, IImagesService
    {
        public ImagesService(IDataProvider provider)
            : base(provider)
        {
        }

        public Image GetImageById(int id)
        {
            return this.Data.Images.Find(id);
        }
    }
}