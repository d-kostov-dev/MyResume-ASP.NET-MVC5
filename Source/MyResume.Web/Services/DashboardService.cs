namespace MyResume.Web.Services
{
    using MyResume.Contracts;
    using MyResume.Web.Services.Base;
    using MyResume.Web.Services.Contracts;

    public class DashboardService : BaseService, IDashboardService
    {
        public DashboardService(IDataProvider provider)
            : base(provider)
        {
        }
    }
}