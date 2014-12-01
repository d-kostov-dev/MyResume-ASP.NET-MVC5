namespace MyResume.Web.Services.Base
{
    using System.Collections.Generic;
    using System.Linq;

    using MyResume.Contracts;
    using MyResume.Web.Services.Contracts;

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
    }
}