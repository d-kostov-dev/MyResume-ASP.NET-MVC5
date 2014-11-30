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

        public string Title { get; set; }

        public string Content { get; set; }

        public string Description { get; set; }

        public int ImageId { get; set; }

        public virtual Image Image { get; set; }

        public bool Featured { get; set; }
    }
}
