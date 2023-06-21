using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amalco.Data.Repositories.Interfaces;
namespace Amalco.Web.ViewComponents
{
    [ViewComponent(Name ="_Menu")]
    public class MenuViewComponent:ViewComponent
    {
        private readonly IUnitofWork uow;
        public MenuViewComponent(IUnitofWork _uow)
        {
            uow = _uow;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        
        {
            var items = await uow.ServiceRepository.ServoceMenuList();
            return View(items);
        }
    }
}
