namespace MyResume.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Project : AuditInfo
    {
        private ICollection<Image> images;

        public Project()
        {
            this.images = new HashSet<Image>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public string URL { get; set; }

        public virtual ICollection<Image> Images 
        { 
            get
            {
                return this.images;
            }

            set
            {
                this.images = value;
            }
        }
    }
}
