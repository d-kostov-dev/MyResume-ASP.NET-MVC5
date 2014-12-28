namespace MyResume.Web.Services.Base
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using MyResume.Contracts;
    using MyResume.Web.Services.Contracts;
    using MyResume.Models;
    using System.Web.Mvc;
    using System.Web;

    public abstract class BaseService : IBaseService
    {
        protected IDataProvider Data { get; private set; }

        public BaseService(IDataProvider data)
        {
            this.Data = data;
        }

        public IDictionary<string, string> GetSettings()
        {
            var settingsList = this.Data.SiteSettings.All().ToDictionary(x => x.Name, x => x.Value);
            return settingsList;
        }


        public ActionResult GetImageById(int id)
        {
            var image = this.Data.Images.Find(id);

            //if (image != null)
            //{
            //    return this.File(image.Content, "image/" + image.FileExtension);
            //}

            return null;
        }
    }
}