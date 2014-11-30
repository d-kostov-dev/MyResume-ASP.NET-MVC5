namespace MyResume.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class SiteSetting : AuditInfo
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(20, MinimumLength = 3)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        [Required]
        public string Value { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 10)]
        public string Description { get; set; }
    }
}
