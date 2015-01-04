namespace MyResume.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Skill : AuditInfo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 1)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int Level { get; set; }

        public int YearsOfExperience { get; set; }

        public int? ImageId { get; set; }

        public virtual Image Image { get; set; }
    }
}
