namespace MyResume.Web.Areas.Administration.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;

    using MyResume.Common;
    using MyResume.Web.Services.Contracts;
    using System.Globalization;

    [Authorize(Roles = GlobalConstants.AdminRole)]
    public class AdminBaseController : Controller
    {
        private IBaseService baseDataProvider;
        private IDictionary<string, string> settings;

        public AdminBaseController(IBaseService dataProvider)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            this.baseDataProvider = dataProvider;
            this.settings = this.LoadSettings();
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

        private IDictionary<string, string> LoadSettings()
        {
            var settingsList = this.baseDataProvider.GetSettings();
            this.ViewBag.Settings = settingsList;

            return settingsList;
        }
    }
}