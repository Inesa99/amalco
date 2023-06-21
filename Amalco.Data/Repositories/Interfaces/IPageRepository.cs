using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Amalco.Data.ViewModels.Page;
namespace Amalco.Data.Repositories.Interfaces
{
    public interface IPageRepository
    {
        Task<List<PageListAdminViewModel>> GetPagesAdmin();
        Task<PageViewModel> GetByIdOrUrl(int?id=null,string url=null,string subUrl=null);
        Task Update(PageViewModel model);
        Task<List<string>> GetUrls();
    }
}
