namespace MyResume.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Education : AuditInfo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Place { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Field { get; set; }

        [StringLength(50, MinimumLength = 2)]
        public string Degree { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int FromYear { get; set; }

        public int ToYear { get; set; }

        public int ImageId { get; set; }

        public virtual Image Image { get; set; }

        public string URL { get; set; }
    }
}
