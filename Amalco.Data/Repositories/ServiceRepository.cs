using System;
using System.Collections.Generic;
using System.Text;
using Amalco.Data.Repositories.Interfaces;
using System.Threading.Tasks;
using Amalco.Data.ViewModels.Service;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Amalco.Data.Helpers;
using Amalco.Data.Models;
using Amalco.Data.ViewModels;

namespace Amalco.Data.Repositories
{
    public class ServiceRepository:BaseRepository,IServiceRepository
    {
        public ServiceRepository(Context _context):base(_context)
        {

        }
        public async Task<List<MenuListVM>> ServoceMenuList()
        {
            var list= await _context.Services.
                GroupBy(s => s.ServiceType)
                .Select(s => new MenuListVM
                {
                    ServiceType = s.Key,
                    ChildMenues = s.Select(m => new ServiceListVM
                    {
                        Title=m.Name,
                        Url=m.Url
                    }).ToList()


                }).ToListAsync();
            list.ForEach(l => l.Title = l.ServiceType.DisplayName());
            return list;
        }

        public async Task<List<ServiceAdminList>> AdminServiceList()
        {
            return await _context.Services.Select(s => new ServiceAdminList
            {
                Id=s.Id,
                Name=s.Name
            }).ToListAsync();
        }

        public async Task<ServiceAddEdit> GetforEdit(int Id)
        {
            return await _context.Services.Where(s => s.Id == Id)
                .Select(s => new ServiceAddEdit
                {
                    Id=s.Id,
                    Name=s.Name,
                    PageTile=s.PageTitle,
                    MetaDescription=s.MetaDescription,
                    Content=s.Content,
                    HeaderText=s.HeaderText,
                    MainImage=s.MainImage,
                    Price=s.Price,
                    Responsibility=s.Responsibility,
                    ServicePayType=s.ServicePayType,
                    ServiceType=s.ServiceType.Value,
                    OrderBannerImage=s.OrderBannerImage,
                    PriceTitle=s.PriceTitle,
                    ResponsibilityTitle=s.ResponsibilityTitle,
                    Url=s.Url

                    
                }).FirstOrDefaultAsync();
        }

        public async Task Update(ServiceAddEdit model)
        {
            var service = await _context.Services.FirstOrDefaultAsync(s => s.Id == model.Id);
            if(service!=null)
            {
                service.MainImage = model.MainImage;
                service.MetaDescription = model.MetaDescription;
                service.PageTitle = model.PageTile;
                service.Name = model.Name;
                service.Responsibility = model.Responsibility;
                service.Price = model.Price;
                service.ModifedDate = DateTime.Now;
                service.Content = model.Content;
                service.HeaderText = model.HeaderText;
                service.ServicePayType = model.ServicePayType;
                service.Url = model.Url;
                service.ServiceType = model.ServiceType;
                service.ResponsibilityTitle = model.ResponsibilityTitle;
                service.PriceTitle = model.PriceTitle;
                service.OrderBannerImage = model.OrderBannerImage;
                _context.Entry(service).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
        }
        public async Task Add(ServiceAddEdit model)
        {
            Service service = new Service
            {
                CreatedDate=DateTime.Now,
                ModifedDate=DateTime.Now,
                Deleted=false,
                MetaDescription=model.MetaDescription,
                PageTitle=model.PageTile,
                Content=model.Content,
                HeaderText=model.HeaderText,
                MainImage=model.MainImage,
                Name=model.Name,
                Price=model.Price,
                Responsibility=model.Responsibility,
                ServicePayType=model.ServicePayType,
                Url=model.Url,
                ServiceType=model.ServiceType,
                ResponsibilityTitle=model.ResponsibilityTitle,
                PriceTitle=model.PriceTitle,
                OrderBannerImage=model.OrderBannerImage,
            };
            await _context.Services.AddAsync(service);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ServiceListVM>> ServicePrices(bool filipin = false)
        {
            return await _context.Services
                .Where(s=>!filipin||(s.Id == 16 || s.Id == 17 || s.Id == 19 || s.Id == 20))
                .Select(s => new ServiceListVM
            {Title=s.Name,
            Price=s.Price,
            MainImage=s.MainImage,
            Url=s.Url,
            ServicePayType=s.ServicePayType

            }).ToListAsync();
        }
        public async Task Delete(int id)
        {
            var delete= await _context.Services.Where(p=>p.Id==id).FirstOrDefaultAsync();
            delete.Deleted = true;
            _context.Entry(delete).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteReview(int id)
        {
            var delete = await _context.Reviews.Where(p => p.Id == id).FirstOrDefaultAsync();
            delete.Deleted = true;
            _context.Entry(delete).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task<ServiceFullView> FullView(string url)
        {
            return await _context.Services.Where(s => s.Url == url)
                .Select(s => new ServiceFullView
                {
                    Id=s.Id,
                    Name=s.Name,
                    Content=s.Content,
                    HeaderTitle=s.HeaderText,
                    MetaDescription=s.MetaDescription,
                    MainImage=s.MainImage,
                    PageTitle=s.PageTitle,
                    Responsibility=s.Responsibility,
                    Price=s.Price,
                    ServicePayType=s.ServicePayType,
                    PriceTitle=s.PriceTitle,
                    ResponsibilityTitle=s.ResponsibilityTitle,
                    IsPhilipin=/*s.Id==16||s.Id==17||*/s.Id==19||s.Id==20
                    
                }).FirstOrDefaultAsync();
        }

        public async Task<List<ReviewVM>> AdminReviewList()
        {
            return await _context.Reviews.Select(r => new ReviewVM
            {
               Id=r.Id,
                Name=r.Name,
                Created=r.CreatedDate
            }).ToListAsync();
        }
        public async Task AddReview(ReviewVM model)
        {
            Review review = new Review
            {
                Content = model.Content,
                Deleted = false,
                CreatedDate = DateTime.Now,
                Image = model.Image,
                Name = model.Name,
                Profession=model.Profession
            };
            await _context.Reviews.AddAsync(review);
            await _context.SaveChangesAsync();
        }
       public async Task UpdateReview(ReviewVM model)
        {
            Review review = await _context.Reviews.FirstOrDefaultAsync(r => r.Id == model.Id);
            review.Content = model.Content;
            review.Image = model.Image;
            review.Name = model.Name;
            review.Profession = model.Profession;
            _context.Entry(review).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            
        }

       public async  Task<ReviewVM> ReviewEdit(int Id)
        {
            return await _context.Reviews.Where(r => r.Id == Id)
                .Select(r => new ReviewVM
                {
                    Id=r.Id,
                    Image=r.Image,
                    Content=r.Content,
                    Name=r.Name,
                    Profession=r.Profession
                }).FirstOrDefaultAsync();
        }

       public async  Task<List<ReviewVM>> GetAllReviews()
        {
            return await _context.Reviews.Select(r => new ReviewVM
            {
                Name=r.Name,
                Content=r.Content,
                Image=r.Image,
                Profession=r.Profession
            }).ToListAsync();
        }

       public async Task<string> ServiceNameById(int Id)
        {
            return await _context.Services.Where(s=>s.Id==Id)
                .Select(s=>s.Name)
                .FirstOrDefaultAsync();
        }

        public async Task<Tuple<int, IEnumerable<InvoiceModel>>> GetInvoices(int pageIndex = 1)
        {
            var count = await _context.Invoices.CountAsync();
            var list = await _context.Invoices
                .OrderBy(i => i.CreatedDate)
                .Select(i => new InvoiceModel
                {
                    Id=i.Id,
                    CreatedDate=i.CreatedDate,
                    PaymentDate=i.PaymentDate,
                    Amount=i.Amount,
                    IsPaid=i.IsPaid,
                    Note=i.Note,
                    ServiceName=i.ServiceName,
                    UniqueId=i.UniqueId
                }).ToListAsync();
            return Tuple.Create(count,list.AsEnumerable());
        }
       public async Task AddInvoice(InvoiceModel model)
        {
            Invoice invoice = new Invoice
            {
                CreatedDate = DateTime.UtcNow.AddHours(3),
                Amount=model.Amount,
                Note=model.Note,
                ServiceName=model.ServiceName,
                UniqueId=model.UniqueId
            };
            await _context.Invoices.AddAsync(invoice);
            await _context.SaveChangesAsync();
        }
       public async Task<InvoiceModel> GetInvoiceByUniqueId(string uniqueId)
        {
            var invoice = await _context.Invoices
                .Where(i => i.UniqueId==uniqueId)
                .Select(i => new InvoiceModel
                {
                    Id = i.Id,
                    CreatedDate = i.CreatedDate,
                    PaymentDate = i.PaymentDate,
                    Amount = i.Amount,
                    IsPaid = i.IsPaid,
                    Note = i.Note,
                    ServiceName = i.ServiceName,
                    UniqueId = i.UniqueId
                }).FirstOrDefaultAsync();
            return invoice;
        }
        public async Task AddVacancy(VacancyVM model)
        {
            Vacancy vacancy = new Vacancy
            {
                CreatedDate = DateTime.UtcNow.AddHours(3),
                Description = model.Description,
                Salary = model.Salary,
                Title = model.Title,
                VacancyType = model.VacancyType,
                ServicePayType = model.ServicePayType,
                SalaryDo = model.SalaryDo
            };
            await _context.Vacancies.AddAsync(vacancy);
            await _context.SaveChangesAsync();
        }
        public async Task<VacancyVM> GetVacancy(int Id)
        {
            var vacancy = await _context.Vacancies.FindAsync(Id);
            return new VacancyVM
            {
                Description=vacancy.Description,
                Id=vacancy.Id,
                Salary=vacancy.Salary,
                Title=vacancy.Title,
                VacancyType=vacancy.VacancyType,
                ServicePayType=vacancy.ServicePayType,
                SalaryDo = vacancy.SalaryDo
                
            };
        }
        public async Task<IEnumerable<VacancyVM>> GetAllVacancy(int page)
        {
            var vacancies = await _context.Vacancies.OrderByDescending(v => v.CreatedDate)
                .Select(v => new VacancyVM
                {
                    Description=v.Description,
                    Id=v.Id,
                    Salary=v.Salary,
                    Title=v.Title,
                    VacancyType=v.VacancyType,
                    ServicePayType=v.ServicePayType,
                    CreatedDate=v.CreatedDate,
                    SalaryDo = v.SalaryDo
                }).ToListAsync();
            return vacancies;
        }
        public async Task UpdateVacancy(VacancyVM model)
        {
            var vacancy = await _context.Vacancies.FindAsync(model.Id);
            vacancy.Title = model.Title;
            vacancy.VacancyType = model.VacancyType;
            vacancy.ServicePayType = model.ServicePayType;
            vacancy.Salary = model.Salary;
            vacancy.Description = model.Description;
            vacancy.SalaryDo = model.SalaryDo;
            await _context.SaveChangesAsync();

        }

        public async Task DeleteVacancy(int Id)
        {
            var vacancy = await _context.Vacancies.FindAsync(Id);
            vacancy.Deleted = true;
            await _context.SaveChangesAsync();
        }
    }
}
