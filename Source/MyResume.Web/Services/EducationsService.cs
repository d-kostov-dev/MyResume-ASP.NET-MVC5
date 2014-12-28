namespace MyResume.Web.Services
{
    using MyResume.Contracts;
    using MyResume.Web.Services.Base;
    using MyResume.Web.Services.Contracts;

    public class EducationsService : BaseService, IEducationsService
    {
        public EducationsService(IDataProvider provider)
            : base(provider)
        {
        }
    }
}