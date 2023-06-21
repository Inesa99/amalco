using System;
using System.Collections.Generic;
using System.Text;
using Amalco.Data.Repositories.Interfaces;
using System.Threading.Tasks;
using Amalco.Data.ViewModels.Page;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace Amalco.Data.Repositories
{
    public class PageRepository:BaseRepository,IPageRepository
    {
        public PageRepository(Context _context):base(_context)
        {

        }

        public async Task<List<PageListAdminViewModel>> GetPagesAdmin()
        {
            return await _context.Pages.Select(p => new PageListAdminViewModel
            {
                Id=p.Id,
                Name=p.PageName
            }).ToListAsync();
        }

        public async Task<PageViewModel> GetByIdOrUrl(int? id = null, string url = null, string subUrl = null)
        {
            return await _context.Pages.Where(p => ((id.HasValue && p.Id == id.Value) || p.Url == url)&&(subUrl==null||p.Parent.Url==subUrl))
                .Select(p => new PageViewModel
                {
                    Id = p.Id,
                    Url=p.Url,
                    MetaDescription = p.MetaDescription,
                    Content = p.Content,
                    PageTitle = p.PageTitle,
                    Name=p.PageName,
                    Content2=p.Content2,
                    ChildPages=p.ChildPages.Select(c=>new ChildPage
                    {
                        Title=c.PageName,
                        Url=c.Url
                    }).ToList()
                }).FirstOrDefaultAsync();

        }

        public async Task Update(PageViewModel model)
        {
            var page = await _context.Pages.FirstOrDefaultAsync(p => p.Id == model.Id);
            page.MetaDescription = model.MetaDescription;
            page.PageTitle = model.PageTitle;
            page.Content = model.Content;
            page.ModifedDate = DateTime.Now;
            page.Content2 = model.Content2;
            _context.Entry(page).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<List<string>> GetUrls()
        {
            var urls = new List<string>();  
            var services = await _context.Services
                .Where(p=>!p.Deleted)
                .Select(p =>p.Url)
                .ToListAsync();

            urls.AddRange(services);
            var pages = await _context.Pages.Select(p=>p.Url).ToListAsync();
            urls.AddRange(pages);
            return urls;
        }
    }
}
