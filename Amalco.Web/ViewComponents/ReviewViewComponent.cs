using Amalco.Data.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amalco.Web.ViewComponents
{
    [ViewComponent(Name = "_ReviewList")]
    public class ReviewViewComponent:ViewComponent
    {
        private readonly IUnitofWork uow;
        public ReviewViewComponent(IUnitofWork _uow)
        {
            uow = _uow;
        }

        public async Task<IViewComponentResult> InvokeAsync()

        {
            var items = await uow.ServiceRepository.GetAllReviews();
            return View(items);
        }
    }
}
