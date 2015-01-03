namespace MyResume.Web.Areas.Administration.Controllers
{
    using System.Web.Mvc;

    using MyResume.Web.Services.Contracts;
    using System.Web;

    public class ImagesController : AdminBaseController
    {
        private IImagesService dataProvider;

        public ImagesController(IImagesService provider)
            : base(provider)
        {
            this.dataProvider = provider;
        }

        [ChildActionOnly]
        public ActionResult GetImageById(int id)
        {
            var image = this.dataProvider.GetImageById(id);

            if (image == null)
            {
                throw new HttpException(404, "Image not found");
            }

            var fileToReturn = File(image.Content, "image/" + image.FileExtension);
            return this.PartialView("_SelectedImage", fileToReturn);
        }

        public ActionResult ShowImage(int? id)
        {
            if (id != null)
            {
                return this.GetImageById(id.Value);
            }
            else
            {
                return this.PartialView("_DefaultImage");
            }
        }
    }
}