namespace MyResume.Web.Services.Contracts
{
    using System.Collections.Generic;

    public interface IBaseService
    {
        IDictionary<string, string> GetSettings();
    }
}