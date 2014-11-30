namespace MyResume.Contracts
{
    using System.Linq;

    using MyResume.Models;

    public interface IRepository<T> where T : class, IAuditInfo
    {
        IQueryable<T> All();

        IQueryable<T> AllWithDeleted();

        T Find(object id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Delete(object id);

        void TotalDelete(T entity);

        int SaveChanges();
    }
}
