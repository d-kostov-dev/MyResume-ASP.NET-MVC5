namespace MyResume.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Certificate : AuditInfo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Title { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Institution { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int IssueYear { get; set; }

        public string InstitutionSite { get; set; }

        public int ImageId { get; set; }

        public virtual Image Image { get; set; }
    }
}
