namespace MyResume.Web.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;
    using AutoMapper.QueryableExtensions;

    using MyResume.Contracts;
    using MyResume.Models;
    using MyResume.Web.Services.Base;
    using MyResume.Web.Services.Contracts;
    using MyResume.Web.Areas.Administration.Models.InputModels;
    
    public class CoursesService : BaseService, ICoursesService
    {
        public CoursesService(IDataProvider provider)
            : base(provider)
        {
        }

        public void Add(AddEditCourseInputModel input)
        {
            var dbModel = Mapper.Map<Course>(input);

            this.Data.Courses.Add(dbModel);
            this.Data.SaveChanges();
        }

        public void Save(AddEditCourseInputModel input)
        {
            var dbModel = Mapper.Map<Course>(input);

            this.Data.Courses.Update(dbModel);
            this.Data.SaveChanges();
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.Data.Courses.All().OrderBy(x => x.Id).Project().To<T>();
        }

        public T GetById<T>(int id)
        {
            var dbResult = this.Data.Courses.All().Where(x => x.Id == id);
            return dbResult.Project().To<T>().FirstOrDefault();
        }

        public void Delete(int id)
        {
            var itemToDelete = this.Data.Courses.Find(id);

            if (itemToDelete != null)
            {
                this.Data.Courses.Delete(itemToDelete);
                this.Data.SaveChanges();
            }
        }
    }
}