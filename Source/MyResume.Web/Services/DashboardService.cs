namespace MyResume.Web.Services
{
    using MyResume.Contracts;
    using MyResume.Web.Services.Base;
    using MyResume.Web.Services.Contracts;
    using System.Collections.Generic;

    public class DashboardService : BaseService, IDashboardService
    {
        public DashboardService(IDataProvider provider)
            : base(provider)
        {
        }
    }
}