namespace MyResume.Web.Services
{
    using MyResume.Contracts;
    using MyResume.Models;
    using MyResume.Web.Services.Base;
    using MyResume.Web.Services.Contracts;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Web;

    public class ImagesService : BaseService, IImagesService
    {
        public ImagesService(IDataProvider provider)
            : base(provider)
        {
        }

        public Image GetById(int id)
        {
            return this.Data.Images.Find(id);
        }


        public int Save(HttpPostedFileBase image)
        {
            using (var memory = new MemoryStream())
            {
                image.InputStream.CopyTo(memory);
                var content = memory.GetBuffer();

                var imageToSave = new Image
                {
                    Content = content,
                    FileExtension = image.FileName.Split(new[] { '.' }).Last(),
                    CreatedOn = DateTime.Now
                };

                this.Data.Images.Add(imageToSave);
                this.Data.SaveChanges();

                return imageToSave.Id;
            }
        }


        public void Delete(int id)
        {
            this.Data.Images.Delete(this.Data.Images.Find(id));
            this.Data.SaveChanges();
        }
    }
}