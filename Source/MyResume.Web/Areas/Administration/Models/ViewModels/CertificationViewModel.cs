namespace MyResume.Web.Areas.Administration.Models.ViewModels
{
    using MyResume.Infrastructure.Mapping;
    using MyResume.Models;
    using MyResume.Web.Areas.Administration.Models.Base;

    public class CertificationViewModel : BaseModel, IMapFrom<Certificate>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Institution { get; set; }

        public string Description { get; set; }

        public int IssueYear { get; set; }

        public string InstitutionSite { get; set; }

        public int? ImageId { get; set; }
    }
}