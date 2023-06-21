using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Amalco.Web.Controllers;
using Amalco.Data.Repositories.Interfaces;
using Amalco.Data.ViewModels.Page;
namespace Amalco.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class StaticPageManageController : BaseController
    {
        public StaticPageManageController(IUnitofWork uow):base(uow)
        {

        }
        public async Task<IActionResult> Index()
        {
            var list = await Uow.PageRepository.GetPagesAdmin();
            return View(list);

        }

        [HttpGet]
       public async Task<IActionResult> Edit(int id)
        {
            var model = await Uow.PageRepository.GetByIdOrUrl(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PageViewModel model)
        {
            await Uow.PageRepository.Update(model);
            return RedirectToAction("Index");
        }

    }
}