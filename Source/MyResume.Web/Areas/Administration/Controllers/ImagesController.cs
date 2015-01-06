namespace MyResume.Web.Areas.Administration.Controllers
{
    using System.Web.Mvc;

    using MyResume.Web.Services.Contracts;
    using System.Web;

    [AllowAnonymous]
    public class ImagesController : AdminBaseController
    {
        private IImagesService dataProvider;

        public ImagesController(IImagesService provider)
            : base(provider)
        {
            this.dataProvider = provider;
        }

        public ActionResult GetImageById(int id)
        {
            var image = this.dataProvider.GetById(id);

            if (image == null)
            {
                throw new HttpException(404, "Image not found");
            }

            return File(image.Content, "image/" + image.FileExtension);
        }

        public ActionResult ShowImage(int? id)
        {
            if (id != null)
            {
                return this.PartialView("_SelectedImage", id);
            }
            else
            {
                return this.PartialView("_DefaultImage");
            }
        }
    }
}