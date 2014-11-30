namespace MyResume.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Image : AuditInfo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public byte[] Content { get; set; }

        [Required]
        public string FileExtension { get; set; }
    }
}
