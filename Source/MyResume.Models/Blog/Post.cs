namespace MyResume.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Post : AuditInfo
    {
        private ICollection<Category> categories;
        private ICollection<Tag> tags;

        public Post()
        {
            this.categories = new HashSet<Category>();
            this.tags = new HashSet<Tag>();
        }

        [Key]
        public int Id { get; set; }

        public virtual ICollection<Category> Categories
        {
            get
            {
                return this.categories;
            }

            set
            {
                this.categories = value;
            }
        }

        public virtual ICollection<Tag> Tags
        {
            get
            {
                return this.tags;
            }

            set
            {
                this.tags = value;
            }
        }

        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Title { get; set; }

        [Required]
        [StringLength(2000, MinimumLength = 50)]
        public string Content { get; set; }

        public string Description { get; set; }

        public string MetaKeywords { get; set; }

        public string MetaDescription { get; set; }

        public int ImageId { get; set; }

        public virtual Image Image { get; set; }

        public bool Featured { get; set; }
    }
}
