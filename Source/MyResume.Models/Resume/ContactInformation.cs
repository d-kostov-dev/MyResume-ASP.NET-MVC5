namespace MyResume.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ContactInformation : AuditInfo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string City { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime? BirthDate { get; set; }

        [StringLength(100, MinimumLength = 10)]
        public string LinkedIn { get; set; }

        [StringLength(100, MinimumLength = 10)]
        public string FaceBook { get; set; }

        [StringLength(20, MinimumLength = 3)]
        public string Skype { get; set; }
    }
}
