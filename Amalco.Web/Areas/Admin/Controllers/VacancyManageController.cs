using Amalco.Data.Repositories.Interfaces;
using Amalco.Data.ViewModels.Service;
using Amalco.Web.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amalco.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class VacancyManageController : BaseController
    {
        IHostingEnvironment _appEnvironment;
        public VacancyManageController(IUnitofWork uow, IHostingEnvironment appEnvironment) : base(uow)
        {
            _appEnvironment = appEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            var list = await Uow.ServiceRepository.GetAllVacancy(1);
            return View(list);
        }

        [HttpGet]
        public async Task<IActionResult> AddEdit(int? Id)
        {
            var model = Id.HasValue ? await Uow.ServiceRepository.GetVacancy(Id.Value) : new VacancyVM();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddEdit(VacancyVM model)
        {
            if(model.Id>0)
            {
                await Uow.ServiceRepository.UpdateVacancy(model);
            }
            else
            {
                await Uow.ServiceRepository.AddVacancy(model);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var delete = await Uow.ServiceRepository.GetVacancy(id);
            return PartialView("_Delete", delete);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteVacancy(int id)
        {
            await Uow.ServiceRepository.DeleteVacancy(id);
            return RedirectToAction("Index");
        }
    }
}
