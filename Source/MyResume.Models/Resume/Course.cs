namespace MyResume.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Course : AuditInfo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string Institution { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int FromYear { get; set; }

        public int ToYear { get; set; }
    }
}
