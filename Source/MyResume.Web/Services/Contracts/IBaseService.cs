namespace MyResume.Web.Services.Contracts
{
    using MyResume.Models;
    using System.Collections.Generic;
    using System.IO;
    using System.Web.Mvc;

    public interface IBaseService
    {
        IDictionary<string, string> GetSettings();

        ActionResult GetImageById(int id);
    }
}