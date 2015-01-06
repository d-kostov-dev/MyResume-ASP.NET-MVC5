namespace MyResume.Web.Controllers
{
    using System.Web.Mvc;

    using MyResume.Web.Services.Contracts;
    using MyResume.Web.Areas.Administration.Models.ViewModels;
    
    public class HomeController : Controller
    {
        private IContactInformationService contactInformationService;
        private IEducationsService educationService;
        private ISkillsService skillsService;
        private ICertificationsService certificationService;
        private ICoursesService coursesService;
        private IProjectsService projectsService;
        private IExperiencesService experienceService;

        public HomeController(
            IContactInformationService contactInformationService,
            IEducationsService educationService,
            ISkillsService skillsService,
            ICertificationsService certificationService,
            ICoursesService coursesService,
            IProjectsService projectsService,
            IExperiencesService experienceService)
        {
            this.contactInformationService = contactInformationService;
            this.educationService = educationService;
            this.skillsService = skillsService;
            this.certificationService = certificationService;
            this.coursesService = coursesService;
            this.projectsService = projectsService;
            this.experienceService = experienceService;
        }

        public ActionResult Index()
        {
            var itemsList = this.contactInformationService.GetFirst();
            return this.View(itemsList);
        }

        public ActionResult Experience()
        {
            var itemsList = this.experienceService.GetAll<ExperienceViewModel>();
            return this.View(itemsList);
        }

        public ActionResult Projects()
        {
            var itemsList = this.projectsService.GetAll<ProjectViewModel>();
            return this.View(itemsList);
        }

        public ActionResult Education()
        {
            var itemsList = this.educationService.GetAll<EducationViewModel>();
            return this.View(itemsList);
        }

        public ActionResult Skills()
        {
            var itemsList = this.skillsService.GetAll<SkillViewModel>();
            return this.View(itemsList);
        }

        public ActionResult Courses()
        {
            var itemsList = this.coursesService.GetAll<CourseViewModel>();
            return this.View(itemsList);
        }

        public ActionResult Certifications()
        {
            var itemsList = this.certificationService.GetAll<CertificationViewModel>();
            return this.View(itemsList);
        }

        public ActionResult Recommendations()
        {
            return this.View();
        }
    }
}