namespace MyResume.Web.Services.Contracts
{
    using System.Collections.Generic;

    using MyResume.Web.Areas.Administration.Models.InputModels;
    using MyResume.Web.Areas.Administration.Models.ViewModels;

    public interface ICertificationsService : IBaseService, ICommonOperationsService
    {
        void Add(AddEditCertificationInputModel input);

        void Save(AddEditCertificationInputModel input);
    }
}