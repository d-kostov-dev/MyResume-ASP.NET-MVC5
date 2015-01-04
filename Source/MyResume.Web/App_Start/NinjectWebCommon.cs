[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(MyResume.Web.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(MyResume.Web.App_Start.NinjectWebCommon), "Stop")]

namespace MyResume.Web.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using MyResume.Contracts;
    using MyResume.Data;
    using MyResume.Data.UnitOfWork;

    using Ninject;
    using Ninject.Web.Common;
    using MyResume.Web.Services.Contracts;
    using MyResume.Web.Services;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper Bootstrapper = new Bootstrapper();

        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            Bootstrapper.Initialize(CreateKernel);
        }

        public static void Stop()
        {
            Bootstrapper.ShutDown();
        }

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IDataProvider>()
                    .To<DataProvider>()
                    .WithConstructorArgument("context", c => new ApplicationDbContext());

            kernel.Bind<IDashboardService>().To<DashboardService>();
            kernel.Bind<ISiteSettingsService>().To<SiteSettingsService>();
            kernel.Bind<IEducationsService>().To<EducationsService>();
            kernel.Bind<IImagesService>().To<ImagesService>();
            kernel.Bind<ISkillsService>().To<SkillsService>();
            kernel.Bind<ICertificationsService>().To<CertificationsService>();
            kernel.Bind<ICoursesService>().To<CoursesService>();
            kernel.Bind<IExperiencesService>().To<ExperiencesService>();
        }        
    }
}
