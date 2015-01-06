namespace MyResume.Contracts
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using MyResume.Models;

    public interface IDbContext
    {
        // General
        DbContext DbContext { get; }

        IDbSet<SiteSetting> SiteSettings { get; set; }

        IDbSet<Image> Images { get; set; }

        // Blog
        IDbSet<Category> Categories { get; set; }

        IDbSet<Tag> Tags { get; set; }

        IDbSet<Post> Posts { get; set; }

        // Resume
        IDbSet<Skill> Skills { get; set; }

        IDbSet<Course> Courses { get; set; }

        IDbSet<Education> Educations { get; set; }

        IDbSet<Experience> Experiences { get; set; }

        IDbSet<Project> Projects { get; set; }

        IDbSet<Certificate> Certificates { get; set; }

        IDbSet<ContactInformation> ContactInformation { get; set; }

        IDbSet<Recommendation> Recommendations { get; set; }

        // Methods
        int SaveChanges();

        IDbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
