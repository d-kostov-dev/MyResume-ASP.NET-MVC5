namespace MyResume.Contracts
{
    using MyResume.Models;

    public interface IDataProvider
    {
        // General
        IDbContext Context { get; }

        IRepository<ApplicationUser> ApplicationUsers { get; }

        IRepository<SiteSetting> SiteSettings { get; }

        IRepository<Image> Images { get; }

        // Blog
        IRepository<Category> Categories { get; }

        IRepository<Tag> Tags { get; }

        IRepository<Post> Posts { get; }

        // Resume
        IRepository<Skill> Skills { get; }

        IRepository<Course> Courses { get; }

        IRepository<Education> Educations { get; }

        IRepository<Experience> Experiences { get; }

        IRepository<Project> Projects { get; }

        IRepository<ContactInformation> ContactInformation { get; }

        IRepository<Certificate> Certificates { get; }

        IRepository<Recommendation> Recommendations { get; }

        // Methods
        int SaveChanges();
    }
}
