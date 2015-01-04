namespace MyResume.Web.Services.Contracts
{
    using System.Collections.Generic;

    public interface ICommonOperationsService
    {
        IEnumerable<T> GetAll<T>();

        T GetById<T>(int id);

        void Delete(int id);
    }
}