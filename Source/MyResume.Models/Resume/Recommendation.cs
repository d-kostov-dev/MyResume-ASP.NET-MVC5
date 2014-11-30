namespace MyResume.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Recommendation : AuditInfo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string FromName { get; set; }

        [Required]
        [StringLength(1000, MinimumLength = 20)]
        public string Content { get; set; }

        public string URL { get; set; }
    }
}
