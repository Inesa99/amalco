using System;
using System.Collections.Generic;
using System.Text;
using Amalco.Data.ViewModels.Service;
using System.Threading.Tasks;
using Amalco.Data.ViewModels;

namespace Amalco.Data.Repositories.Interfaces
{
    public interface IServiceRepository
    {
        Task<List<MenuListVM>> ServoceMenuList();
        Task<List<ServiceAdminList>> AdminServiceList();
        Task<ServiceAddEdit> GetforEdit(int Id);
        Task Update(ServiceAddEdit model);
        Task Add(ServiceAddEdit model);
        Task<List<ServiceListVM>> ServicePrices(bool filipin=false);
        Task Delete(int id);
        Task DeleteReview(int id);
        Task<ServiceFullView> FullView(string url);
        Task<List<ReviewVM>> AdminReviewList();
        Task AddReview(ReviewVM model);
        Task UpdateReview(ReviewVM model);
        Task<ReviewVM> ReviewEdit(int Id);
        Task<List<ReviewVM>> GetAllReviews();
        Task<string> ServiceNameById(int Id);
        Task<Tuple<int, IEnumerable<InvoiceModel>>> GetInvoices(int pageIndex=1);
        Task AddInvoice(InvoiceModel model);
        Task<InvoiceModel> GetInvoiceByUniqueId(string uniqueId);
        Task AddVacancy(VacancyVM model);
        Task<VacancyVM> GetVacancy(int Id);
        Task<IEnumerable<VacancyVM>> GetAllVacancy(int page);
        Task UpdateVacancy(VacancyVM model);
        Task DeleteVacancy(int Id);
    }
}
