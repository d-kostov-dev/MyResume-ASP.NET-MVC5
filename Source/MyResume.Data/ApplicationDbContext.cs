namespace MyResume.Data
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    using Microsoft.AspNet.Identity.EntityFramework;

    using MyResume.Contracts;
    using MyResume.Data.Migrations;
    using MyResume.Models;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IDbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        public IDbSet<SiteSetting> SiteSettings { get; set; }

        public IDbSet<Image> Images { get; set; }

        public IDbSet<Contact> Contacts { get; set; }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Tag> Tags { get; set; }

        public IDbSet<Post> Posts { get; set; }

        public IDbSet<Skill> Skills { get; set; }

        public IDbSet<Course> Courses { get; set; }

        public IDbSet<Education> Educations { get; set; }

        public IDbSet<Experience> Experiences { get; set; }

        public IDbSet<Project> Projects { get; set; }

        public IDbSet<Certificate> Certificates { get; set; }

        public IDbSet<ContactInformation> ContactInformation { get; set; }

        public IDbSet<Recommendation> Recommendations { get; set; }

        public DbContext DbContext
        {
            get
            {
                return this;
            }
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
