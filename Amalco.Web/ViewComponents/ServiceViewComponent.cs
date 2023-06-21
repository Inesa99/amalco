using Amalco.Data.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amalco.Web.ViewComponents
{
    [ViewComponent(Name = "_ServiceList")]
    public class ServiceViewComponent:ViewComponent
    {
        private readonly IUnitofWork uow;
        public ServiceViewComponent(IUnitofWork _uow)
        {
            uow = _uow;
        }

        public async Task<IViewComponentResult> InvokeAsync(bool isPhilipin=false)

        {
            var items = await uow.ServiceRepository.ServicePrices(isPhilipin);
            return View(items);
        }
    }
}
