namespace MyResume.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Contact : AuditInfo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string From { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
