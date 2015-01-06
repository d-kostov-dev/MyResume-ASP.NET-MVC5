namespace MyResume.Data.UnitOfWork
{
    using System;
    using System.Collections.Generic;

    using MyResume.Contracts;
    using MyResume.Data.Repositories;
    using MyResume.Models;
    
    public class DataProvider : IDataProvider
    {
        private IDbContext databaseContext;
        private IDictionary<Type, object> createdRepositories;

        public DataProvider(IDbContext context)
        {
            this.databaseContext = context;
            this.createdRepositories = new Dictionary<Type, object>();
        }

        public IRepository<ApplicationUser> ApplicationUsers
        {
            get { return this.GetRepository<ApplicationUser>(); }
        }

        public IDbContext Context
        {
            get { return this.databaseContext; }
        }

        public IRepository<SiteSetting> SiteSettings
        {
            get { return this.GetRepository<SiteSetting>(); }
        }

        public IRepository<Image> Images
        {
            get { return this.GetRepository<Image>(); }
        }

        public IRepository<Category> Categories
        {
            get { return this.GetRepository<Category>(); }
        }

        public IRepository<Tag> Tags
        {
            get { return this.GetRepository<Tag>(); }
        }

        public IRepository<Post> Posts
        {
            get { return this.GetRepository<Post>(); }
        }

        public IRepository<Skill> Skills
        {
            get { return this.GetRepository<Skill>(); }
        }

        public IRepository<Course> Courses
        {
            get { return this.GetRepository<Course>(); }
        }

        public IRepository<Education> Educations
        {
            get { return this.GetRepository<Education>(); }
        }

        public IRepository<Experience> Experiences
        {
            get { return this.GetRepository<Experience>(); }
        }

        public IRepository<Project> Projects
        {
            get { return this.GetRepository<Project>(); }
        }

        public IRepository<ContactInformation> ContactInformation
        {
            get { return this.GetRepository<ContactInformation>(); }
        }

        public IRepository<Certificate> Certificates
        {
            get { return this.GetRepository<Certificate>(); }
        }

        public IRepository<Recommendation> Recommendations
        {
            get { return this.GetRepository<Recommendation>(); }
        }

        public int SaveChanges()
        {
            return this.databaseContext.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class, IAuditInfo
        {
            var typeOfRepository = typeof(T);

            if (!this.createdRepositories.ContainsKey(typeOfRepository))
            {
                var newRepository = Activator.CreateInstance(typeof(GenericRepository<T>), this.databaseContext);
                this.createdRepositories.Add(typeOfRepository, newRepository);
            }

            return (IRepository<T>)this.createdRepositories[typeOfRepository];
        }
    }
}