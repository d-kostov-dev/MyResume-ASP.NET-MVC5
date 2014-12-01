namespace MyResume.Web.Areas.Administration.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;

    using MyResume.Common;

    [Authorize(Roles = GlobalConstants.AdminRole)]
    public class AdminBaseController : Controller
    {
        private IDictionary<string, string> settings;

        public AdminBaseController()
        {
            this.settings = this.GetSettings();
        }

        public string GetSetting(string key)
        {
            string result = null;

            if (this.settings.ContainsKey(key))
            {
                result = this.settings[key];
            }

            return result;
        }

        private IDictionary<string, string> GetSettings()
        {
            ////var settingsList = this.Data.SiteSettings.All().ToDictionary(x => x.Name, x => x.Value);
            ////this.ViewBag.Settings = settingsList;
            ////return settingsList;

            return null;
        }
    }
}