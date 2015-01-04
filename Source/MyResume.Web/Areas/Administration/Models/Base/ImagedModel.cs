namespace MyResume.Web.Areas.Administration.Models.Base
{
    using System.Web;

    public class ImagedModel : BaseModel
    {
        public HttpPostedFileBase FileUploaded { get; set; }

        public int? ImageId { get; set; }
    }
}